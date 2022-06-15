using MassTransit;
using Shared.Contracts.OfferManager;
using Shared.Contracts.TransportManager;
using TransportManager.Services;

namespace HotelManager.Consumers;

public class TransportRequestConsumer : IConsumer<GetTransportOffers>, IConsumer<IsTransportOfferAvailable>,
    IConsumer<GetLocations>, IConsumer<GetTransportById>, IConsumer<RefreshTransportOffer>
{
    private readonly ILogger<TransportRequestConsumer> _logger;
    private readonly TransportService _transportService;

    public TransportRequestConsumer(ILogger<TransportRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }

    public async Task Consume(ConsumeContext<GetTransportOffers> context)
    {
        var request = context.Message;
        _logger.LogInformation("GetAllTransports Received: {Id}", request.Guid);

        var transports = _transportService.GetTransportOffers(request.Filter);
        var Response = new GetTransportOffersResult(transports);
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<IsTransportOfferAvailable> context)
    {
        var request = context.Message;
        _logger.LogInformation("IsTransportOfferAvailable Received: {Id}", request.Guid);

        var isAvailable = _transportService.IsTransportOfferAvailable(request.TransportOffer);
        var Response = new IsTransportOfferAvailableResult(isAvailable);
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<GetLocations> context)
    {
        var request = context.Message;
        _logger.LogInformation("GetLocations Received: {Id}", request.Guid);

        var locations = _transportService.GetAllLocations();
        var Response = new GetLocationsResult { Locations = locations };
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<GetTransportById> context)
    {
        var request = context.Message;
        _logger.LogInformation("GetTransportById Received: {Id}", request.Guid);
        var transport = _transportService.GetTransport(request.TransportId);
        var Response = new GetTransportByIdResult { Transport = transport };
        await context.RespondAsync(Response);
    }

    public async Task Consume(ConsumeContext<RefreshTransportOffer> context)
    {
        var request = context.Message;
        _logger.LogInformation("RefreshTransportOfferResult Received: {Id}", request.Guid);
        var offer = _transportService.RefreshTransportOffer(request.TransportOffer);
        var reponse = new RefreshTransportOfferResult(offer);
        await context.RespondAsync(reponse);
    }
}
