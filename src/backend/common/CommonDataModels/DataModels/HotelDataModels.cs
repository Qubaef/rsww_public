using Microsoft.EntityFrameworkCore;
using Shared.DataModels.Offer;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shared.DataModels.Hotel;

public class HotelStaticData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Description { get; set; }
    public double Stars { get; set; }
    public int BasePrice { get; set; }
    public RoomCounts RoomCounts { get; set; }
}

[Owned]
public class RoomCounts
{
    public int Small { get; set; }
    public int Medium { get; set; }
    public int Large { get; set; }
    public int Apartment { get; set; }
    public int Studio { get; set; }

    public Dictionary<RoomType, int> toDictionary()
    {
        return new Dictionary<RoomType, int> { { RoomType.Small, Small }, { RoomType.Medium, Medium }, { RoomType.Large, Large }, { RoomType.Apartment, Apartment }, { RoomType.Studio, Studio } };
    }

    public int GetCountForType(RoomType roomType)
    {
        switch (roomType)
        {
            case RoomType.Small:
                return Small;
            case RoomType.Medium:
                return Medium;
            case RoomType.Large:
                return Large;
            case RoomType.Apartment:
                return Apartment;
            case RoomType.Studio:
                return Studio;
            default:
                return 0;
        }
    }

    public void SetCountForType(RoomType roomType, int count)
    {
        switch (roomType)
        {
            case RoomType.Small:
                Small = count; break;
            case RoomType.Medium:
                Medium = count; break;
            case RoomType.Large:
                Large = count; break;
            case RoomType.Apartment:
                Apartment = count; break;
            case RoomType.Studio:
                Studio = count; break;
            default: break;
        }
    }

    public RoomType FindLargestAvailable()
    {
        if (Studio > 0)
        {
            return RoomType.Studio;
        }

        if (Apartment > 0)
        {
            return RoomType.Apartment;
        }

        if (Large > 0)
        {
            return RoomType.Large;
        }

        if (Medium > 0)
        {
            return RoomType.Medium;
        }

        if (Small > 0)
        {
            return RoomType.Small;
        }

        return RoomType.None;
    }
}

public enum RoomType
{
    Small,
    Medium,
    Large,
    Apartment,
    Studio,
    None
}

public class RoomTypeStaticData
{
    public int PriceModifier { get; set; }
    public int AdultBeds { get; set; }
    public int MinChildrenLT18Beds { get; set; }
    public int MinChildrenLT10Beds { get; set; }
    public int MinChildrenLT3Beds { get; set; }

    public int GetTotalBedsNumber()
    {
        return MinChildrenLT3Beds + MinChildrenLT10Beds + MinChildrenLT18Beds + AdultBeds;
    }
}

public class HotelEvent
{
    [BsonId]
    public Guid Id { get; set; }
    public RoomReservation reservation{get;set;}
    public EventType eventType { get; set; }
}

public enum EventType
{
    Reserved,
    Cancelled
}