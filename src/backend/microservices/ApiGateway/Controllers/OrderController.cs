using ApiGateway.DataModels;
using ApiGateway.SignalR;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shared.Contracts.OrderManager;
using Shared.DataModels.Order;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IRequestClient<GetOrders> _clientGetOrders;
        private readonly IRequestClient<GetStatistics> _clientGetStatistics;
        private readonly ILogger<OrderController> _logger;
        
        public OrderController(ILogger<OrderController> logger, IRequestClient<GetOrders> clientGetOrders, IRequestClient<GetStatistics> clientGetStatistics)
        {
            _clientGetOrders = clientGetOrders;
            _clientGetStatistics = clientGetStatistics;
            _logger = logger;
        }

        [Authorize]
        [HttpGet("get")]
        public async Task<IEnumerable<Order>> GetUserOrders()
        {
            // Requirement 8

            // Get userId from cookies
            var userId = User.FindFirst("Id")?.Value;
            int userIdInt = int.Parse(userId);

            var request = new GetOrders()
            {
                Guid = Guid.NewGuid(),
                UserId = userIdInt
            };

            var response = await _clientGetOrders.GetResponse<GetOrdersResult>(request);
            return response.Message.Orders;
        }

        [HttpGet("get-preferences")]
        // public DetailedPreferences GetDetailedPreferences()
        public async Task<OrdersStatistics?> GetDetailedPreferences()
        {
            if (OrderStatsCache.Stats == null)
            {
                var request = new GetStatistics()
                {
                    Guid = Guid.NewGuid()
                };

                var response = await _clientGetStatistics.GetResponse<GetStatisticsResult>(request);
                OrderStatsCache.Stats = response.Message.Statistics;
            }
            return OrderStatsCache.Stats;
        }
    }
}