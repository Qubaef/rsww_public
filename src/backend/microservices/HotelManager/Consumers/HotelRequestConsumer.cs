using HotelManager.Services;
using MassTransit;
using Shared.Contracts.HotelManager;
using Shared.Contracts.OfferManager;

namespace HotelManager.Consumers;

public class HotelRequestConsumer : IConsumer<GetHotelOffers>, IConsumer<GetHotelById>, IConsumer<IsHotelOfferAvailable>, IConsumer<RefreshHotelOffer>
{
    private readonly ILogger<HotelRequestConsumer> _logger;
    private readonly HotelServices _hotelService;

    public HotelRequestConsumer(ILogger<HotelRequestConsumer> logger, HotelContext hotelContext, MongoHotelContext mongoHotelContext)
    {
        _logger = logger;
        _hotelService = new HotelServices(hotelContext, mongoHotelContext);
    }
    public async Task Consume(ConsumeContext<GetHotelOffers> context)
    {
        GetHotelOffers request = context.Message;
        _logger.LogInformation("GetAllHotelsEvent Received: {Id}", request.Guid);

        var hotelOffers = _hotelService.GetHotelOffers(request.Filter);
        var Response = new GetHotelOffersResult(hotelOffers);
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<GetHotelById> context)
    {
        GetHotelById request = context.Message;
        _logger.LogInformation("GetAllHotelsEvent Received: {Id}", request.Guid);

        var Hotel = _hotelService.GetHotelByIdFull(request.HotelId);
        var Response = new GetHotelByIdResult
        {
            Hotel = Hotel,
            Guid = request.Guid
        };

        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<IsHotelOfferAvailable> context)
    {
        var request = context.Message;
        _logger.LogInformation("IsTransportOfferAvailable Received: {Id}", request.Guid);

        var isAvailable = _hotelService.IsHotelOfferAvailable(request.HotelOffer);
        var Response = new IsHotelOfferAvailableResult(isAvailable);
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<RefreshHotelOffer> context)
    {
        var request = context.Message;
        _logger.LogInformation("RefreshTransportOffer Received: {Id}", request.Guid);

        var offer = _hotelService.RefreshHotelOffer(request.HotelOffer);
        var Response = new RefreshHotelOfferResult(offer);
        await context.RespondAsync(Response);
    }
}
