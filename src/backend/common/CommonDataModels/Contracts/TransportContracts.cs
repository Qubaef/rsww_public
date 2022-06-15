using Shared.Contracts.Common;
using Shared.DataModels.Offer;
using Shared.DataModels.Transport;

namespace Shared.Contracts.TransportManager;
public class GetTransportOffers : Contract
{
    public TransportOfferFilter Filter { get; }

    public GetTransportOffers(TransportOfferFilter filter)
    {
        Filter = filter;
    }
}

public class GetTransportOffersResult : Contract
{
    public IEnumerable<TransportOffer> Transports { get; }

    public GetTransportOffersResult(IEnumerable<TransportOffer> transports)
    {
        Transports = transports;
    }
}

public class CancelTransport : Contract
{
    public TransportOffer TransportOffer { get; set; }
    public Guid OrderId { get; set; }
}

public class CancelTransportResult : Contract
{
    public bool Success { get; set; }
}

public class GetTransportById : Contract
{
    public int TransportId { get; set; }
}

public class GetTransportByIdResult : Contract
{
    public TransportDataModel Transport { get; set; }
}

public class ReserveTransport : Contract
{
    public TransportOffer TransportOffer { get; set; }
    public Guid OrderId { get; set; }
}

public class ReserveTransportSuccess : Contract
{
    public Guid OrderId { get; set; }
    public Guid TransportOrderId { get; set; }
}

public class ReserveTransportFailure : Contract
{
    public Guid OrderId { get; set; }
}

public class GetLocations : Contract
{
}

public class GetLocationsResult : Contract
{
    public List<string> Locations { get; set; }
}