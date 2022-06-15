using MassTransit;
using Shared.Contracts;
using Shared.DataModels.Order;

namespace TOOperator.Consumers;

public class SendOrderConsumer : IConsumer<SendOrderContract>
{
    private readonly ILogger<SendOrderConsumer> _logger;
    private readonly IBus _bus;
    private static List<Order> orders = new();

    public SendOrderConsumer(ILogger<SendOrderConsumer> logger, IBus bus)
    {
        _logger = logger;
        _bus = bus;
    }
    public async Task Consume(ConsumeContext<SendOrderContract> context)
    {
        SendOrderContract request = context.Message;
        var order = request.Order;
        _logger.LogInformation($"[TOOperator]{DateTime.Now} recieved confirmation of id:{order.Id}\n " +
                               $"HotelId: {order.Reservation.HotelId} Price: {order.FinalPrice}");
        orders.Add(order);
    }
}