using MassTransit;
using OrderManager.Services;
using Shared.Contracts.OrderManager;

namespace OrderManager.Consumers
{
    public class OrderRequestConsumer : IConsumer<GetOrders>, IConsumer<GetStatistics>
    {
        private readonly IBus _bus;
        private readonly ILogger<OrderRequestConsumer> _logger;
        private readonly OrdersCollection _ordersCollection;

        public OrderRequestConsumer(
            ILogger<OrderRequestConsumer> logger,
            OrdersCollection ordersCollection,
            IBus bus)
        {
            _logger = logger;
            _ordersCollection = ordersCollection;
            _bus = bus;
        }
        public async Task Consume(ConsumeContext<GetOrders> context)
        {
            GetOrders request = context.Message;
            _logger.LogInformation("GetOrders event Received: {Id}", request.Guid);

            var result = _ordersCollection.GetOrders(request.UserId);

            var response = new GetOrdersResult
            {
                Guid = request.Guid,
                Orders = result
            };

            await context.RespondAsync(response);
        }

        public async Task Consume(ConsumeContext<GetStatistics> context)
        {
            GetStatistics request = context.Message;
            _logger.LogInformation("GetStatistics event Received: {Id}", request.Guid);
            var result = _ordersCollection.GetStatistics();
            var response = new GetStatisticsResult
            {
                Guid = request.Guid,
                Statistics = result
            };
            await context.RespondAsync(response);
        }
    }
}
