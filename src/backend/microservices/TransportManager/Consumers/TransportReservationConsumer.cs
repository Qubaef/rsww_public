using MassTransit;
using Shared.Contracts;
using Shared.Contracts.TransportManager;
using TransportManager.Services;

namespace TransportManager.Consumers;

public class TransportReservationConsumer : IConsumer<ReserveTransport>, IConsumer<CancelTransport>, IConsumer<UpdateTransport>
{
    private IBus _bus;
    private readonly ILogger<TransportReservationConsumer> _logger;
    private readonly TransportService _transportService;

    public TransportReservationConsumer(ILogger<TransportReservationConsumer> logger, TransportContext transportContext, IBus bus)
    {
        _logger = logger;
        _transportService = new TransportService(transportContext);
        _bus = bus;
    }

    public async Task Consume(ConsumeContext<ReserveTransport> context)
    {
        ReserveTransport request = context.Message;
        _logger.LogInformation("ReserveTransport event Received: {Id}", request.Guid);

        var result = _transportService.ReserveTransport(request.TransportOffer.TransportId,
            request.TransportOffer.NumberOfSeats);

        if (result.Item1)
        {
            var response = new ReserveTransportSuccess()
            {
                Guid = request.Guid,
                OrderId = request.OrderId,
                TransportOrderId = result.Item2
            };
            await context.RespondAsync(response);            
        }
        else
        {
            var response = new ReserveTransportFailure()
            {
                Guid = request.Guid,
                OrderId = request.OrderId
            };
            await context.RespondAsync(response);
        }
    }

    public async Task Consume(ConsumeContext<CancelTransport> context)
    {
        CancelTransport request = context.Message;
        _logger.LogInformation("CancelTransport event Received: {Id}", request.Guid);

        _transportService.CancelReservation(request.TransportOffer.TransportId, request.TransportOffer.NumberOfSeats, request.OrderId);
    }

    public async Task Consume(ConsumeContext<UpdateTransport> context)
    {
        var contract = context.Message;

        if (contract.NewPrice != null)
        {
            _transportService.UpdateTransportPrice(contract.Id, (int)contract.NewPrice);
        }

        if (contract.NewAvailableSeats != null)
        {
            _transportService.UpdateTransportAvailableSeats(contract.Id, (int)contract.NewAvailableSeats);
        }

        if (contract.NewPrice != null || contract.NewAvailableSeats != null)
        {
            await _bus.Publish(new TransportUpdated(contract));
        }
    }
}

internal class TransportReservationConsumerDefinition :
    ConsumerDefinition<TransportReservationConsumer>
{
    public TransportReservationConsumerDefinition()
    {
        // override the default endpoint name
        EndpointName = "transport-reservation-service";

        // limit the number of messages consumed concurrently
        // this applies to the consumer only, not the endpoint
        ConcurrentMessageLimit = 1;
    }

    protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator,
        IConsumerConfigurator<TransportReservationConsumer> consumerConfigurator)
    {
        // configure message retry with millisecond intervals
        // endpointConfigurator.UseMessageRetry(r => r.Intervals(100, 200, 500, 800, 1000));

        // use the outbox to prevent duplicate events from being published
        endpointConfigurator.UseInMemoryOutbox();
    }
}