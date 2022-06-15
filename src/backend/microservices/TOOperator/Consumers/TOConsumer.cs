using MassTransit;
using Shared.Contracts;
using TOOperator.Services;

namespace TOOperator.Consumers;

public class TOConsumer : IConsumer<OffersFetched>, IConsumer<GetLastTourOperatorUpdates>
{
    private readonly ResourceChangeGenerator _generator;
    private readonly ILogger<TOConsumer> _logger;

    public TOConsumer(ResourceChangeGenerator generator, ILogger<TOConsumer> logger)
    {
        _generator = generator;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<OffersFetched> context)
    {
        var notification = context.Message;
        _logger.LogInformation("OffersFetched received");
        _generator.Modify(notification.Offers);
    }

    public async Task Consume(ConsumeContext<GetLastTourOperatorUpdates> context)
    {
        GetLastTourOperatorUpdates request = context.Message;
        _logger.LogInformation("GetStatistics event Received: {Id}", request.Guid);
        var result = _generator.GetUpdateHistory();
        var response = new LastTourOperatorUpdates(result);
        await context.RespondAsync(response);
    }
}
