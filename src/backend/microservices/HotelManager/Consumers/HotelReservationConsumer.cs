
using HotelManager.Services;
using MassTransit;
using Shared.Contracts.HotelManager;
using Shared.DataModels.Offer;

namespace HotelManager.Consumers;

public class HotelReservationConsumer : IConsumer<ReserveHotel>, IConsumer<CancelHotel>
{
    private readonly ILogger<HotelRequestConsumer> _logger;
    private readonly HotelServices _hotelService;

    public HotelReservationConsumer(ILogger<HotelRequestConsumer> logger, HotelContext hotelContext, MongoHotelContext mongoHotelContext)
    {
        _logger = logger;
        _hotelService = new HotelServices(hotelContext, mongoHotelContext);
    }
    public async Task Consume(ConsumeContext<ReserveHotel> context)
    {
        ReserveHotel request = context.Message;
        _logger.LogInformation("ReserveHotel event Received: {Id}", request.Guid);

        RoomReservation? reservation = _hotelService.ReserveOffer(request.HotelOffer);

        bool success = reservation != null;
        
        if (success)
        {
            var response = new ReserveHotelSuccess()
            {
                Guid = request.Guid,
                Reservation = reservation,
                OrderId = request.OrderId
            };
            _logger.LogInformation("Hotel reservation success: {Id}", request.Guid);
            await context.RespondAsync(response);
        }
        else
        {
            var response = new ReserveHotelFailure()
            {
                Guid = request.Guid,
                OrderId = request.OrderId
            };
            _logger.LogInformation("Hotel reservation failed: {Id}", request.Guid);
            await context.RespondAsync(response);
        }
        
    }

    public async Task Consume(ConsumeContext<CancelHotel> context)
    {
        CancelHotel request = context.Message;
        _logger.LogInformation("CancelHotel event Received: {Id}", request.Guid);

        _hotelService.CancelReservation(request.Reservation);
        
    }
}

internal class HotelReservationConsumerDefinition :
    ConsumerDefinition<HotelReservationConsumer>
{
    public HotelReservationConsumerDefinition()
    {
        // override the default endpoint name
        EndpointName = "hotel-reservation-service";

        // limit the number of messages consumed concurrently
        // this applies to the consumer only, not the endpoint
        ConcurrentMessageLimit = 1;
    }

    protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator,
        IConsumerConfigurator<HotelReservationConsumer> consumerConfigurator)
    {
        // configure message retry with millisecond intervals
        // endpointConfigurator.UseMessageRetry(r => r.Intervals(100, 200, 500, 800, 1000));

        // use the outbox to prevent duplicate events from being published
        endpointConfigurator.UseInMemoryOutbox();
    }
}