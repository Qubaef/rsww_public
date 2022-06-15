using MassTransit;
using OfferGenerator.Services;
using Shared.Contracts.OfferManager;

namespace OfferGenerator.Consumers;

public class OfferRequestConsumer : IConsumer<GetOffers>, IConsumer<IsOfferAvailable>, IConsumer<RefreshOffer>
{
    private readonly ILogger<OfferRequestConsumer> _logger;
    private readonly OfferGeneratorService _offerService;

    public OfferRequestConsumer(ILogger<OfferRequestConsumer> logger, OfferGeneratorService offerService)
    {
        _logger = logger;
        _offerService = offerService;
    }
    public async Task Consume(ConsumeContext<GetOffers> context)
    {
        var request = context.Message;
        _logger.LogInformation("GetOffersFiltered Received: {Id}", request.Guid);

        var offers = await _offerService.GetOffers(request.Filter);
        var response = new GetOffersResult(offers);
        await context.RespondAsync(response);
    }

    public async Task Consume(ConsumeContext<IsOfferAvailable> context)
    {
        var request = context.Message;
        _logger.LogInformation("IsOfferAvailable Received: {Id}", request.Guid);

        var isAvailable = await _offerService.IsOfferAvailable(request.Offer);
        var response = new IsOfferAvailableResult(isAvailable);
        await context.RespondAsync(response);
    }

    public async Task Consume(ConsumeContext<RefreshOffer> context)
    {
        var request = context.Message;
        _logger.LogInformation("RefreshOffer Received: {Id}", request.Guid);

        var offer = await _offerService.RefreshOffer(request.Offer);
        var response = new RefreshOfferResult(offer);
        await context.RespondAsync(response);
    }
}