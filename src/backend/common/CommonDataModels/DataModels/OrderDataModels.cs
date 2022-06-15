using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;
using Shared.DataModels.Transport;

namespace Shared.DataModels.Order;

public class Order
{
    [BsonId]
    public Guid Id { get; set; }

    public int UserId { get; set; }
    public bool IsPaid { get; set; }
    public RoomReservation Reservation { get; set; }
    public TransportOffer TransportTo { get; set; }
    public TransportOffer TransportBack { get; set; }

    public DateTime DateOfOrder { get; set; }
    public double FinalPrice { get; set; }
    public Guid TransportToId { get; set; }
    public Guid TransportBackId { get; set; }
}

public class OrderConfirmation
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public string RoomType { get; set; }
    public int RoomId { get; set; }
    public int TransportId { get; set; }
    public int FinalPrice { get; set; }

}

public class OrdersStatistics
{
    public IDictionary<string, int> DestinationStats { get; set; }
    public IDictionary<int, int> HotelsStatistic { get; set; }
    public IDictionary<RoomType, int> RoomsStatistic { get; set; }
    public IDictionary<TransportType, int> TransportTypeStatistic { get; set; }

    public OrdersStatistics()
    {
        DestinationStats = new Dictionary<string, int>();
        HotelsStatistic = new Dictionary<int, int>();
        RoomsStatistic = new Dictionary<RoomType, int>();
        TransportTypeStatistic = new Dictionary<TransportType, int>();
    }
}