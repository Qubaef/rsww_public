using Microsoft.AspNetCore.Mvc;
using Shared.DataModels.Order;

namespace TOOperator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TOOperatorController : ControllerBase
    {

        private readonly ILogger<TOOperatorController> _logger;
        private static List<Order> orders = new();

        public TOOperatorController(ILogger<TOOperatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAllOrders")]
        public IEnumerable<Order> Get()
        {
            return orders;
        }

        [HttpPost(Name = "AddOrder")]
        public bool AddOrder([FromBody] Order order)
        {
            _logger.LogInformation($"[TOOperator]{DateTime.Now} recieved confirmation if id:{order.Id}\n " +
                                   $"HotelId: {order.Reservation.HotelId} Price: {order.FinalPrice}");
            orders.Add(order);
            return true;
        }
    }
}