using MassTransit;
using PaymentManager.Services;
using Shared.Contracts.PaymentManager;

namespace PaymentManager.Consumers;

public class PaymentConsumer : IConsumer<PaymentContracts>
{
    private readonly ILogger<PaymentConsumer> _logger;
    private readonly PaymentService _paymentService;

    public PaymentConsumer(ILogger<PaymentConsumer> logger, PaymentService paymentService)
    {
        _logger = logger;
        _paymentService = paymentService;
    }
    public async Task Consume(ConsumeContext<PaymentContracts> context)
    {
        PaymentContracts request = context.Message;
        _logger.LogInformation("PerformPayment event Received: {Id}", request.Guid);

        var result = await _paymentService.PerformPayment(request.CardNumber);
        _logger.LogInformation("Payment status: {Success}", result);

        if (result)
        {
            var response = new PaymentSuccess()
            {
                Guid = context.Message.Guid,
                OrderId = request.OrderId
            };
            await context.RespondAsync(response);
        }
        else
        {
            var response = new PaymentFailure()
            {
                Guid = context.Message.Guid,
                OrderId = request.OrderId
            };
            await context.RespondAsync(response);
        }
        
    }
}