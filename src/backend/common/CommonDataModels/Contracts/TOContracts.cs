using Shared.Contracts.Common;
using Shared.Contracts.OfferManager;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;
using Shared.DataModels.Order;

namespace Shared.Contracts;

public class SendOrderContract : Contract
{
    public Order Order { get; set; }
}
public class SendOrderResult : Contract
{
    public bool Success { get; set; }
}


public class OfferPurchased
{
    public int TransportToId { get; set; }
    public int TransportBackId { get; set; }
    public int HotelId { get; set; }
}

public class OfferBooked : Contract
{
    public Offer Offer { get; set; }
}

public class OfferDeleted : Contract
{
    public Offer Offer { get; set; }
}


public class TourOperatorUpdate : Contract
{
    public int Id { get; set; } // Resource Id
}

public class TourOperatorTransportUpdate : TourOperatorUpdate
{
    public int? NewAvailableSeats { get; set; }
    public int? NewPrice { get; set; }
}

public class TourOperatorHotelUpdate : TourOperatorUpdate
{
    public int? NewBasePrice { get; set; }
    public RoomType? RoomType { get; set; }
    public int? NewCount { get; set; }
}

public class UpdateTransport : TourOperatorTransportUpdate {}

public class TransportUpdated : TourOperatorTransportUpdate
{
    public TransportUpdated() { }
    public TransportUpdated(UpdateTransport updateTransport)
    {
        Id = updateTransport.Id;
        NewAvailableSeats = updateTransport.NewAvailableSeats;
        NewPrice = updateTransport.NewPrice;
    }
}

public class UpdateHotel : TourOperatorHotelUpdate { }

public class HotelUpdated : TourOperatorHotelUpdate
{
    public HotelUpdated() { }
    public HotelUpdated(UpdateHotel updateHotel)
    {
        Id = updateHotel.Id;
        NewBasePrice = updateHotel.NewBasePrice;
        RoomType = updateHotel.RoomType;
        NewCount = updateHotel.NewCount;
    }
}

public class OffersFetched : Contract
{
    public IEnumerable<Offer> Offers { get; set; }
    public OffersFetched() : base() { }
    public OffersFetched(GetOffersResult getOffersResult) : base()
    {
        Offers = getOffersResult.Offers;
    }
}

public class GetLastTourOperatorUpdates : Contract { }

public class LastTourOperatorUpdates : Contract
{
    public IList<TourOperatorUpdate> tourOperatorUpdates { get; set; }

    public LastTourOperatorUpdates(IList<TourOperatorUpdate> tourOperatorUpdates) : base()
    {
        this.tourOperatorUpdates = tourOperatorUpdates;
    }
}
