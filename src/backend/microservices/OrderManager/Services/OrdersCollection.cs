using MongoDB.Driver;
using Shared.DataModels.Hotel;
using Shared.DataModels.Order;
using Shared.DataModels.Transport;

namespace OrderManager.Services;


public class OrdersCollection
{
    // Collection of all orders per user (userId)
    private readonly OrderContext context;

    public OrdersCollection(OrderContext context)
    {
        this.context = context;
    }

    public Guid AddOrder(Order order)
    {
        context.OrderCollection.InsertOne(order);
        return order.Id;
    }

    public Guid UpdateOrder(Order order)
    {
        context.OrderCollection.ReplaceOne(x => x.Id == order.Id, order);
        return order.Id;
    }

    public void RemoveOrder(Guid orderId)
    {
        context.OrderCollection.DeleteOne(x => x.Id == orderId);
    }

    public List<Order> GetOrders(int userId)
    {
        return context.OrderCollection.Find(x => x.UserId == userId).ToList();
    }

    public List<Order> GetOrders()
    {
        // Get all orders from the database
        return context.OrderCollection.Find(_ => true).ToList();
    }

    public async Task<Order> GetOrder(Guid orderId)
    {
        return (await context.OrderCollection.FindAsync(x => x.Id == orderId)).FirstOrDefault();
    }

    public IEnumerable<Order> GetOrdersNotPaidOlderThan(int seconds)
    {
        return context.OrderCollection.Find(x =>
            x.IsPaid == false &&
            x.DateOfOrder < DateTime.Now.AddSeconds(-seconds)).ToList();
    }

    public OrdersStatistics GetStatistics()
    {
        var answer = new OrdersStatistics
        {
            DestinationStats = GetDestinationStats(),
            HotelsStatistic = GetHotelsStats(),
            RoomsStatistic = GetRoomTypeStats(),
            TransportTypeStatistic = GetTransportTypeStats()
        };
        return answer;
    }

    public Dictionary<string, int> GetDestinationStats()
    {
        var pipeline = new EmptyPipelineDefinition<Order>()
            .Group(x => x.TransportTo.To, g => new { Destination = g.Key, Count = g.Count() });

        var result = context.OrderCollection.Aggregate(pipeline).ToList();

        return result.ToDictionary(x => x.Destination, x => x.Count);
    }

    public Dictionary<int, int> GetHotelsStats()
    {
        var pipeline = new EmptyPipelineDefinition<Order>()
            .Group(x => x.Reservation.HotelId, g => new { Hotel = g.Key, Count = g.Count() });
        var result = context.OrderCollection.Aggregate(pipeline).ToList();
        return result.ToDictionary(x => x.Hotel, x => x.Count);
    }

    public Dictionary<TransportType, int> GetTransportTypeStats()
    {
        var toPipeline = new EmptyPipelineDefinition<Order>()
            .Group(x => x.TransportTo.TransportType, g => new { Type = g.Key, Count = g.Count() });
        var backPipeline = new EmptyPipelineDefinition<Order>()
            .Group(x => x.TransportBack.TransportType, g => new { Type = g.Key, Count = g.Count() });
        var result = context.OrderCollection.Aggregate(toPipeline).ToList();
        var result2 = context.OrderCollection.Aggregate(backPipeline).ToList();
        return (from e in result.Concat(result2)
                group e by e.Type into g
                select new { Name = g.Key, Count = g.Sum(kvp => kvp.Count) })
            .ToDictionary(item => item.Name, item => item.Count);
    }

    public Dictionary<RoomType, int> GetRoomTypeStats()
    {
        var roomsReservationList = context.OrderCollection.Find(x => true).ToList().Select(x => x.Reservation.HotelOffer.OfferRoomCounts).ToList();
        var roomTypeCounts = new Dictionary<RoomType, int>();
        foreach (var roomReservation in roomsReservationList)
        {
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                if(roomType == RoomType.None)
                    continue;
                if (roomTypeCounts.ContainsKey(roomType))
                {
                    roomTypeCounts[roomType] += roomReservation.toDictionary()[roomType];
                }
                else
                {
                    roomTypeCounts.Add(roomType, roomReservation.toDictionary()[roomType]);
                }
            }
        }
        return roomTypeCounts;
    }
}
