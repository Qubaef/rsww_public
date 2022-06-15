using Shared.Contracts.Common;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;


namespace Shared.Contracts.HotelManager;

public class GetAllHotels : Contract { }

public class GetAllHotelsResult : Contract
{
    public IEnumerable<HotelStaticData>? Hotels { get; set; }
}

public class CancelHotel : Contract
{
    public RoomReservation Reservation { get; set; }
}

public class CancelHotelResult : Contract
{
    public bool Success { get; set; }
}

public class GetHotelById : Contract
{
    public int HotelId { get; set; }
}

public class GetHotelByIdResult : Contract
{
    public HotelStaticData Hotel { get; set; }
}

public class GetHotelOffers : Contract
{
    public HotelOfferFilter Filter { get; }

    public GetHotelOffers(HotelOfferFilter filter)
    {
        Filter = filter;
    }
}

public class GetHotelOffersResult : Contract
{
    public IEnumerable<HotelOffer> HotelOffers { get; }

    public GetHotelOffersResult(IEnumerable<HotelOffer> hotelOffers)
    {
        HotelOffers = hotelOffers;
    }
}

public class ReserveHotel : Contract
{
    public Guid OrderId { get; set; }
    public HotelOffer HotelOffer { get; set; }
}

public class ReserveHotelResult
{
    public Guid Guid { get; set; }
    public RoomReservation Reservation { get; set; }
    public bool Success { get; set; }
}

public class ReserveHotelSuccess : Contract
{
    public Guid OrderId { get; set; }
    public RoomReservation Reservation { get; set; }
}

public class ReserveHotelFailure : Contract
{
    public Guid OrderId { get; set; }    
}