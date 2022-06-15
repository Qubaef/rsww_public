using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Shared.DataModels.Hotel;
using Shared.DataModels.Transport;

namespace Shared.DataModels.Offer;


public class OfferStatic
{
    public Offer offer { get; set; }
    public HotelStaticData hotelData { get; set; }
    public TransportDataModel transportTo { get; set; }
    public TransportDataModel transportBack { get; set; }
}

public class Offer
{
    public HotelOffer Hotel { get; set; }
    public TransportOffer TransportTo { get; set; }
    public TransportOffer TransportBack { get; set; }
    public MealOffer MealOffer { get; set; }

    public double BasePrice { get; set; }
    public double Discount { get; set; }
    public double FinalPrice { get; set; }

    public Offer() { }

    public Offer(HotelOffer hotel, TransportOffer transportTo, TransportOffer transportBack, MealOffer mealOffer, double discount)
    {
        Hotel = hotel;
        TransportTo = transportTo;
        TransportBack = transportBack;
        MealOffer = mealOffer;
        Discount = discount;
        CalculatePrices(discount);
    }

    private void CalculatePrices(double discount)
    {
        var Prices = new double[] { Hotel.Price, TransportTo.Price, TransportBack.Price, MealOffer.Price };
        BasePrice = Prices.Sum();
        FinalPrice = Math.Round(BasePrice * discount);
    }
}

[Owned]
public class HotelOffer
{
    public int HotelId { get; set; }

    public DateTime From { get; set; }
    public DateTime To { get; set; }

    public double Price { get; set; }

    public RoomCounts OfferRoomCounts { get; set; }
}

public class RoomReservation
{
    public int Id { get; set; }
    public HotelOffer HotelOffer { get; set; }
    public int HotelId { get; set; }
}

public class TransportOffer
{
    public int TransportId { get; set; }

    public DateTime DateTime { get; set; }

    public string From { get; set; }
    public string To { get; set; }

    public double Price { get; set; }

    public int NumberOfSeats { get; set; }
    
    public TransportType TransportType { get; set; }
}

public class MealOffer
{
    public MealOfferType Type { get; set; }
    public double Price { get; set; }
}


public enum MealOfferType
{
    NoMeals,
    Breakfast,
    BreakfastAndDinner,
    ThreeMeals,
    AllInclusive
}

public class TransportOfferFilter
{
    public DateTime DateTime { get; set; }
    public int RequiredSeats { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public IEnumerable<TransportType> Types { get; set; }

    public TransportOfferFilter() { }

    public TransportOfferFilter(OfferFilter offerFilter, TransportDirection direction)
    {
        RequiredSeats = offerFilter.TotalSeats();
        Types = offerFilter.TransportTypes;
        if (direction == TransportDirection.To)
        {
            DateTime = offerFilter.DepartDate;
            From = offerFilter.From;
            To = offerFilter.To;
        }
        else
        {
            DateTime = offerFilter.ReturnDate;
            From = offerFilter.To;
            To = offerFilter.From;
        }
    }

    public FilterDefinition<TransportDataModel> toMongoFilter()
    {
        var DateFrom = DateTime.Date;
        var DateTo = DateTime.Date.AddDays(1);

        var builder = Builders<TransportDataModel>.Filter;
        var filter = builder.Gte(x => x.DateTime, DateFrom) &
                     builder.Lt(x => x.DateTime, DateTo) &
                     builder.Eq(x => x.From, From) &
                     builder.Eq(x => x.To, To) &
                     builder.Gte(x => x.AvailableSeats, RequiredSeats) &
                     builder.In(x => x.Type, Types);
        return filter;
    }
}

public enum TransportDirection
{
    To,
    Back
}

public class DestinationPreferences
{
    // Popular destination and amount of orders placed to them
    public Dictionary<string, int> PopularDestinations { get; set; }
}

public class DetailedPreferences
{
    // Popular hotels and amount of orders placed to them
    public Dictionary<string, int> PopularHotels { get; set; }

    // Popular rooms and amount of orders placed to them
    public Dictionary<string, int> PopularRooms { get; set; }

    // Popular transport types and amount of orders placed to them
    public Dictionary<string, int> PopularTransportTypes { get; set; }
}

public class HotelOfferFilter
{
    public int MinAdultsCount { get; set; }
    public int MinChildrenLT18Count { get; set; }
    public int MinChildrenLT10Count { get; set; }
    public int MinChildrenLT3Count { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Destination { get; set; }
    public int TotalNumber()
    {
        return MinAdultsCount + MinChildrenLT18Count + MinChildrenLT10Count + MinChildrenLT3Count;
    }

    public HotelOfferFilter() { }
    public HotelOfferFilter(OfferFilter offerFilter)
    {
        MinAdultsCount = offerFilter.MinAdultsCount;
        MinChildrenLT18Count = offerFilter.MinChildrenLT18Count;
        MinChildrenLT10Count = offerFilter.MinChildrenLT10Count;
        MinChildrenLT3Count = offerFilter.MinChildrenLT3Count;
        StartDate = offerFilter.DepartDate;
        EndDate = offerFilter.ReturnDate;
        Destination = offerFilter.To;
    }

    public HotelOfferFilter(HotelOfferFilter source)
    {
        MinAdultsCount = source.MinAdultsCount;
        MinChildrenLT18Count = source.MinChildrenLT18Count;
        MinChildrenLT10Count = source.MinChildrenLT10Count;
        MinChildrenLT3Count = source.MinChildrenLT3Count;
        Destination = source.Destination;
        StartDate = source.StartDate;
        EndDate = source.EndDate;
    }

}

public class OfferFilter
{
    public string From { get; set; }
    public string To { get; set; }

    public DateTime DepartDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public int MinAdultsCount { get; set; }

    public int MinChildrenLT3Count { get; set; }

    public int MinChildrenLT10Count { get; set; }

    public int MinChildrenLT18Count { get; set; }

    public IEnumerable<TransportType> TransportTypes { get; set; }

    public int TotalSeats()
    {
        return MinAdultsCount + MinChildrenLT3Count + MinChildrenLT10Count + MinChildrenLT18Count;
    }
}