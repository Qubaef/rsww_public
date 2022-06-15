using Shared.Contracts.Common;

namespace Shared.Contracts.PaymentManager;
public class PaymentContracts : Contract
{
    public string CardNumber { get; set; }
    public Guid OrderId { get; set; }
}

public class PaymentSuccess : Contract
{
    public Guid OrderId { get; set; }
}

public class PaymentFailure : Contract
{
    public Guid OrderId { get; set; }
}