namespace ApiGateway.DataModels;

public class OrderPayment
{
    public Guid OrderId { get; set; }
    public string CardNumber { get; set; }
}