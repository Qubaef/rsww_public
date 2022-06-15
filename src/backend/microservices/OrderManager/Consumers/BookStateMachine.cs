using MassTransit;
using OrderManager.Services;
using Shared.Contracts;
using Shared.Contracts.HotelManager;
using Shared.Contracts.OrderManager;
using Shared.Contracts.PaymentManager;
using Shared.Contracts.TransportManager;
using Shared.DataModels.Offer;
using Shared.DataModels.Order;

public class BookState :
    SagaStateMachineInstance, ISagaVersion
{
    public Guid CorrelationId { get; set; }
    public Guid? ExpirationId { get; set; }     // Required for scheduler
    public int Version { get; set; }
    public int State { get; set; }
    public Offer Offer { get; set; }
    public Order Order { get; set; } = new Order();


    // WA: Recipient data to be able to respond to the request
    // Response Address
    public string? ResponseAddress { get; set; }

    // RequestId from the context
    public Guid? RequestId { get; set; }
}

public class BookStateMachine :
    MassTransitStateMachine<BookState>
{
    private readonly ILogger<BookStateMachine> _logger;
    private readonly OrdersCollection _ordersCollection;

    private const int OrderTimeout = 60;

    // Booking order
    private Event<BookOrder> BookOrder { get; set; }

    private State AwaitingToTransportConfirmation { get; set; }
    private State AwaitingBackTransportConfirmation { get; set; }
    private Event<ReserveTransportSuccess> ReserveTransportSuccess { get; set; }
    private Event<ReserveTransportFailure> ReserveTransportFailure { get; set; }

    private State AwaitingHotelConfirmation { get; set; }
    private Event<ReserveHotelSuccess> ReserveHotelSuccess { get; set; }
    private Event<ReserveHotelFailure> ReserveHotelFailure { get; set; }

    private State OrderBooked { get; set; } = null!;
    private Schedule<BookState, OrderExpired> OrderExpired { get; set; }

    // Purchasing booked order
    private Event<PurchaseOrder> PurchaseOrder { get; set; }

    private State AwaitingPaymentConfirmation { get; set; }
    private Event<PaymentSuccess> AcceptPayment { get; set; }
    private Event<PaymentFailure> RejectPayment { get; set; }

    public BookStateMachine(
        ILogger<BookStateMachine> logger,
        OrdersCollection ordersCollection)
    {
        _logger = logger;
        _ordersCollection = ordersCollection;

        // Initialize States
        InstanceState(x => x.State);

        // Define Events
        ConfigureEventCorrelationIds();

        // Initial behavior definition
        Initially(SetSubmitOrderHandler());

        SetCompletedWhenFinalized();

        // Behaviors definitions
        During(AwaitingToTransportConfirmation, SetReserveToTransportHandlerSuccess(), SetReserveToTransportHandlerFailure());
        During(AwaitingBackTransportConfirmation, SetReserveBackTransportHandlerSuccess(), SetReserveBackTransportHandlerFailure());
        During(AwaitingHotelConfirmation, SetReserveHotelHandlerSuccess(), SetReserveHotelHandlerFailure());
        During(OrderBooked, SetPurchaseOrderHandler(), SetOrderTimeoutHandler());
        During(AwaitingPaymentConfirmation, SetAcceptPaymentHandler(), SetRejectPaymentHandler());

        // During(Rejected, SetLatePaymentHandler());
    }

    private void ConfigureEventCorrelationIds()
    {
        Event(() => BookOrder, x =>
            x.CorrelateById(context => context.Message.Guid));

        Event(() => ReserveTransportSuccess, x =>
            x.CorrelateById(context => context.Message.OrderId));

        Event(() => ReserveTransportFailure, x =>
            x.CorrelateById(context => context.Message.OrderId));

        Event(() => ReserveHotelSuccess, x =>
            x.CorrelateById(context => context.Message.OrderId));

        Event(() => ReserveHotelFailure, x =>
            x.CorrelateById(context => context.Message.OrderId));

        Event(() => PurchaseOrder, e =>
        {
            e.CorrelateById(context => context.Message.OrderId);

            e.OnMissingInstance(m =>
            {
                return m.Execute(x => x.Respond(new PurchaseOrderResult()
                {
                    Guid = x.Message.OrderId,
                    Success = false
                }));
            });
        });

        Event(() => AcceptPayment, x =>
            x.CorrelateById(context => context.Message.OrderId));

        Event(() => RejectPayment, x =>
            x.CorrelateById(context => context.Message.OrderId));

        // Create Schedule event
        Schedule(() => OrderExpired, x => x.ExpirationId, x =>
        {
            x.Delay = TimeSpan.FromSeconds(OrderTimeout);
            x.Received = e => e.CorrelateById(context => context.Message.OrderId);
        });
    }

    private EventActivityBinder<BookState, BookOrder> SetSubmitOrderHandler() =>
        When(BookOrder)
            .Then(x => UpdateSagaState(x.Saga, x.Message.Offer))
            .Then(x =>
            {
                x.Saga.Order.Id = x.Message.Guid;
                x.Saga.CorrelationId = x.Message.Guid;
                x.Saga.Order.UserId = x.Message.UserId;
                x.Saga.Order.FinalPrice = x.Message.Offer.FinalPrice;
            })
            .Then(x =>
            {
                // Save the requester data to be able to respond to the request
                x.Saga.RequestId = x.RequestId;
                x.Saga.ResponseAddress = x.ResponseAddress!.ToString();
            })
            .TransitionTo(AwaitingToTransportConfirmation)
            .Then(x => _logger.LogInformation($"Switching to AwaitingToTransportConfirmation state (OrderId={x.Saga.Order.Id})."))
            .ThenAsync(x => x.Publish(new ReserveTransport
            {
                TransportOffer = x.Message.Offer.TransportTo,
                OrderId = x.Saga.Order.Id,
            }));

    private EventActivityBinder<BookState, ReserveTransportSuccess> SetReserveToTransportHandlerSuccess() =>
        When(ReserveTransportSuccess)
            .TransitionTo(AwaitingBackTransportConfirmation)
            .Then(x => _logger.LogInformation($"Switching to AwaitingBackTransportConfirmation state (OrderId={x.Saga.Order.Id})."))
            .Then(x => x.Saga.Order.TransportTo = x.Saga.Offer.TransportTo)
            .Then(x => x.Saga.Order.TransportToId = x.Message.TransportOrderId)
            .ThenAsync(x => x.Publish(new ReserveTransport
            {
                TransportOffer = x.Saga.Offer.TransportBack,
                OrderId = x.Saga.Order.Id,
            }));

    private EventActivityBinder<BookState, ReserveTransportFailure> SetReserveToTransportHandlerFailure() =>
        When(ReserveTransportFailure)
            .Then(x => _logger.LogInformation($"AwaitingBackTransportConfirmation failure (OrderId={x.Saga.Order.Id})."))
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new BookOrderResult()
                    {
                        OrderId = x.Saga.Order.Id,
                        Success = false
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .Finalize();

    private EventActivityBinder<BookState, ReserveTransportSuccess> SetReserveBackTransportHandlerSuccess() =>
        When(ReserveTransportSuccess)
            .TransitionTo(AwaitingHotelConfirmation)
            .Then(x => _logger.LogInformation($"Switching to AwaitingHotelConfirmation state (OrderId={x.Saga.Order.Id})."))
            .Then(x => x.Saga.Order.TransportBack = x.Saga.Offer.TransportBack)
            .Then(x => x.Saga.Order.TransportBackId = x.Message.TransportOrderId)
            .ThenAsync(x => x.Publish(new ReserveHotel()
            {
                OrderId = x.Saga.Order.Id,
                HotelOffer = x.Saga.Offer.Hotel
            }));

    private EventActivityBinder<BookState, ReserveTransportFailure> SetReserveBackTransportHandlerFailure() =>
        When(ReserveTransportFailure)
            .Then(x => _logger.LogInformation($"AwaitingBackTransportConfirmation failure (OrderId={x.Saga.Order.Id})."))
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportTo,
                OrderId = x.Saga.Order.TransportToId
            }))
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new BookOrderResult()
                    {
                        OrderId = x.Saga.Order.Id,
                        Success = false
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .Finalize();

    private EventActivityBinder<BookState, ReserveHotelSuccess> SetReserveHotelHandlerSuccess() =>
        When(ReserveHotelSuccess)
            .TransitionTo(OrderBooked)
            .Then(x => _logger.LogInformation($"Switching to OrderBooked state (OrderId={x.Saga.Order.Id})."))
            .Then(x => x.Saga.Order.Reservation = x.Message.Reservation)
            .Then(x =>
            {
                // Fill the rest order data
                x.Saga.Order.IsPaid = false;
                x.Saga.Order.DateOfOrder = DateTime.Now;

                // Save completed order to the database
                x.Saga.Order.Id = _ordersCollection.AddOrder(x.Saga.Order);
            })
            .ThenAsync(x => x.Publish(new OfferBooked()
            {
                Offer = x.Saga.Offer,
                Guid = Guid.NewGuid()
            }))
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new BookOrderResult()
                    {
                        OrderId = x.Saga.Order.Id,
                        Success = true
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .Schedule(OrderExpired, context => new OrderExpired()
            {
                OrderId = context.Message.OrderId,
            });

    private EventActivityBinder<BookState, ReserveHotelFailure> SetReserveHotelHandlerFailure() =>
        When(ReserveHotelFailure)
            .Then(x => _logger.LogInformation($"AwaitingHotelConfirmation failure (OrderId={x.Saga.Order.Id})."))
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportTo,
                OrderId = x.Saga.Order.TransportToId
            }))
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportBack,
                OrderId = x.Saga.Order.TransportBackId
            }))
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new BookOrderResult()
                    {
                        OrderId = x.Saga.Order.Id,
                        Success = false
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .Finalize();

    private EventActivityBinder<BookState, PurchaseOrder> SetPurchaseOrderHandler() =>
        When(PurchaseOrder)
            .TransitionTo(AwaitingPaymentConfirmation)
            .Then(x => _logger.LogInformation($"Payment send (OrderId={x.Saga.Order.Id})."))
            .Then(x =>
            {
                // Save the requester data to be able to respond to the request
                x.Saga.RequestId = x.RequestId;
                x.Saga.ResponseAddress = x.ResponseAddress!.ToString();
            })
            .ThenAsync(x => x.Publish(new PaymentContracts()
            {
                OrderId = x.Saga.Order.Id,
                CardNumber = x.Message.CardNumber
            }))
    .Unschedule(OrderExpired);

    private EventActivityBinder<BookState, OrderExpired> SetOrderTimeoutHandler() =>
        When(OrderExpired.Received)
            .Then(x => _logger.LogInformation($"Order expired (OrderId={x.Saga.Order.Id})."))
            .Then(x =>
            {
                // Delete order from the database
                _ordersCollection.RemoveOrder(x.Saga.Order.Id);
            })
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportTo,
                OrderId = x.Saga.Order.TransportToId
            }))
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportBack,
                OrderId = x.Saga.Order.TransportBackId
            }))
            .ThenAsync(x => x.Publish(new CancelHotel()
            {
                Reservation = x.Saga.Order.Reservation
            }))
            .ThenAsync(x => x.Publish(new OfferDeleted()
            {
                Offer = x.Saga.Offer
            }))
            .Finalize();

    private EventActivityBinder<BookState, PaymentSuccess> SetAcceptPaymentHandler() =>
        When(AcceptPayment)
            .Then(x => _logger.LogInformation($"Payment accepted (OrderId={x.Saga.Order.Id})."))
            .Then(x =>
            {
                // Update order to paid status
                x.Saga.Order.IsPaid = true;
                x.Saga.Order.Id = _ordersCollection.UpdateOrder(x.Saga.Order);
            })
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new PurchaseOrderResult()
                    {
                        Success = true
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .ThenAsync(x => x.Publish(new OfferPurchased()
            {
                TransportToId = x.Saga.Order.TransportTo.TransportId,
                TransportBackId = x.Saga.Order.TransportBack.TransportId,
                HotelId = x.Saga.Order.Reservation.HotelId
            }))
            .Finalize();

    private EventActivityBinder<BookState, PaymentFailure> SetRejectPaymentHandler() =>
        When(RejectPayment)
            .TransitionTo(OrderBooked)
            .Then(x => _logger.LogInformation($"Payment failed (OrderId={x.Saga.Order.Id})."))
            .Then(x =>
            {
                // Remove order from the database
                _ordersCollection.RemoveOrder(x.Saga.Order.Id);
            })
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportTo,
                OrderId = x.Saga.Order.TransportToId
            }))
            .ThenAsync(x => x.Publish(new CancelTransport()
            {
                TransportOffer = x.Saga.Offer.TransportBack,
                OrderId = x.Saga.Order.TransportBackId
            }))
            .ThenAsync(x => x.Publish(new CancelHotel()
            {
                Reservation = x.Saga.Order.Reservation
            }))
            .ThenAsync(async x =>
            {
                ISendEndpoint responseEndpoint = await x.GetSendEndpoint(new Uri(x.Saga.ResponseAddress!));

                await responseEndpoint.Send(
                    new PurchaseOrderResult()
                    {
                        Success = false
                    },
                    callback: sendContext => sendContext.RequestId = x.Saga.RequestId);
            })
            .ThenAsync(x => x.Publish(new OfferDeleted()
            {
                Offer = x.Saga.Offer
            }));
    

    private static void UpdateSagaState(BookState state, Offer order)
    {
        state.Offer = order;
    }
}