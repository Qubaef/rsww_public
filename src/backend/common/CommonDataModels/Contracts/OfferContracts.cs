using Shared.Contracts.Common;
using Shared.DataModels.Offer;

namespace Shared.Contracts.OfferManager;
public class GetOffers : Contract
{
    public OfferFilter Filter { get; set; }

    public GetOffers(OfferFilter filter)
    {
        Filter = filter;
    }
}

public class GetOffersResult : Contract
{
    public IEnumerable<Offer> Offers { get; set; }

    public GetOffersResult(IEnumerable<Offer> offers)
    {
        Offers = offers;
    }
}

public class IsHotelOfferAvailable : Contract
{
    public HotelOffer HotelOffer { get; set; }

    public IsHotelOfferAvailable(HotelOffer hotelOffer)
    {
        HotelOffer = hotelOffer;
    }
}

public class IsHotelOfferAvailableResult : Contract
{
    public bool IsAvailable { get; set; }

    public IsHotelOfferAvailableResult(bool isAvailable)
    {
        IsAvailable = isAvailable;
    }
}

public class IsOfferAvailable : Contract
{
    public Offer Offer { get; set; }

    public IsOfferAvailable(Offer offer)
    {
        Offer = offer;
    }
}

public class IsOfferAvailableResult : Contract
{
    public bool IsAvailable { get; set; }

    public IsOfferAvailableResult(bool isAvailable)
    {
        IsAvailable = isAvailable;
    }
}

public class IsTransportOfferAvailable : Contract
{
    public TransportOffer TransportOffer { get; set; }

    public IsTransportOfferAvailable(TransportOffer transportOffer)
    {
        TransportOffer = transportOffer;
    }
}

public class IsTransportOfferAvailableResult : Contract
{
    public bool IsAvailable { get; set; }

    public IsTransportOfferAvailableResult(bool isAvailable)
    {
        IsAvailable = isAvailable;
    }
}


public class RefreshOffer : Contract
{
    public Offer Offer { get; set; }

    public RefreshOffer(Offer offer)
    {
        Offer = offer;
    }
}

public class RefreshOfferResult : Contract
{
    public Offer? Offer { get; set; }

    public RefreshOfferResult(Offer? offer)
    {
        Offer = offer;
    }
}



public class RefreshTransportOffer : Contract
{
    public TransportOffer TransportOffer { get; set; }

    public RefreshTransportOffer(TransportOffer transportOffer)
    {
        TransportOffer = transportOffer;
    }
}

public class RefreshTransportOfferResult : Contract
{
    public TransportOffer? TransportOffer { get; set; }

    public RefreshTransportOfferResult(TransportOffer? transportOffer)
    {
        TransportOffer = transportOffer;
    }
}

public class RefreshHotelOffer : Contract
{
    public HotelOffer HotelOffer { get; set; }

    public RefreshHotelOffer(HotelOffer hotelOffer)
    {
        HotelOffer = hotelOffer;
    }
}

public class RefreshHotelOfferResult : Contract
{
    public HotelOffer? HotelOffer { get; set; }

    public RefreshHotelOfferResult(HotelOffer? hotelOffer)
    {
        HotelOffer = hotelOffer;
    }
}