using Microsoft.AspNetCore.Mvc;
using OrderManager.Services;
using Shared.DataModels.Order;

namespace OrderManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly OrdersCollection _ordersCollection;
        private readonly ILogger<OrderController> _logger;

        public OrderController(
            ILogger<OrderController> logger,
            OrderContext context,
            OrdersCollection ordersCollection)
        {
            _logger = logger;
            _ordersCollection = ordersCollection;
        }
        
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _ordersCollection.GetOrders();
        }

        [HttpGet]
        public ActionResult<OrdersStatistics> GetOrdersStatistics()
        {
            var ans = _ordersCollection.GetStatistics();
            string json = System.Text.Json.JsonSerializer.Serialize(ans);
            Console.WriteLine(json);
            return ans;
        }
    }
}