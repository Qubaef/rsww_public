using HotelManager.Services;
using MassTransit;
using Shared.Contracts;
using Shared.DataModels.Hotel;

namespace HotelManager.Consumers;

public class HotelUpdateConsumer : IConsumer<UpdateHotel>
{
    private IBus _bus;
    private readonly ILogger<HotelRequestConsumer> _logger;
    private readonly HotelServices _hotelService;

    public HotelUpdateConsumer(ILogger<HotelRequestConsumer> logger, HotelContext hotelContext, MongoHotelContext mongoContext, IBus bus)
    {
        _logger = logger;
        _hotelService = new HotelServices(hotelContext, mongoContext);
        _bus = bus;
    }

    public async Task Consume(ConsumeContext<UpdateHotel> context)
    {
        var contract = context.Message;

        if (contract.NewBasePrice != null)
        {
            _hotelService.UpdateHotelPrice(contract.Id, (int)contract.NewBasePrice);
        }

        if (contract.RoomType != null && contract.NewCount != null)
        {
            _hotelService.UpdateHotelRoomCount(contract.Id, (RoomType)contract.RoomType, (int)contract.NewCount);
        }

        if (contract.NewBasePrice != null || (contract.RoomType != null && contract.NewCount != null))
        {
            await _bus.Publish(new HotelUpdated(contract));
        }
    }
}

internal class HotelUpdateConsumerDefinition :
    ConsumerDefinition<HotelUpdateConsumer>
{
    public HotelUpdateConsumerDefinition()
    {
        // override the default endpoint name
        EndpointName = "hotel-reservation-service";

        // limit the number of messages consumed concurrently
        // this applies to the consumer only, not the endpoint
        ConcurrentMessageLimit = 1;
    }

    protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator,
        IConsumerConfigurator<HotelUpdateConsumer> consumerConfigurator)
    {
        // configure message retry with millisecond intervals
        // endpointConfigurator.UseMessageRetry(r => r.Intervals(100, 200, 500, 800, 1000));

        // use the outbox to prevent duplicate events from being published
        endpointConfigurator.UseInMemoryOutbox();
    }
}