using Shared.Contracts.Common;
using Shared.DataModels.Offer;
using Shared.DataModels.Order;

namespace Shared.Contracts.OrderManager;

public class BookOrder : Contract
{
    public Guid CorrelationId { get; set; }
    public int UserId { get; set; }
    public Offer Offer { get; set; }
}

public class BookOrderResult : Contract
{
    public Guid? OrderId { get; set; }

    public bool Success { get; set; }
}

public class GetOrders : Contract
{
    public int UserId { get; set; }
}

public class GetOrdersResult : Contract
{
    public IEnumerable<Order> Orders { get; set; }
}

public class PurchaseOrder : Contract
{
    public int UserId { get; set; }
    public Guid OrderId { get; set; }
    public Guid CorrelationId { get; set; }
    public string CardNumber { get; set; }
}

public class PurchaseOrderResult : Contract
{
    public bool Success { get; set; }
}

public class GetStatistics : Contract
{
}

public class GetStatisticsResult : Contract
{
    public OrdersStatistics? Statistics { get; set; }
}


public class OrderBookedSuccess : Contract
{
}

public class OrderBookedFailure : Contract
{
}

public class OrderExpired : Contract
{
    public Guid OrderId { get; set; }
}
