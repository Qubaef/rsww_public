using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;
using Shared.DataModels.Order;

namespace ApiGateway.DataModels
{
    public static class OrderStatsCache
    {
        public static OrdersStatistics? Stats { get; set; } = null;

        public static void AddOffer(Offer offer)
        {
            if(Stats == null)
                Stats = new OrdersStatistics();
            // Add destination stats
            if (Stats.DestinationStats.ContainsKey(offer.TransportTo.To))
            {
                Stats.DestinationStats[offer.TransportTo.To]++;
            }
            else
            {
                Stats.DestinationStats.Add(offer.TransportTo.To, 1);
            }

            // Add hotel stats
            if (Stats.HotelsStatistic.ContainsKey(offer.Hotel.HotelId))
            {
                Stats.HotelsStatistic[offer.Hotel.HotelId]++;
            }
            else
            {
                Stats.HotelsStatistic.Add(offer.Hotel.HotelId, 1);
            }

            // Add room stats
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                if (roomType == RoomType.None)
                    continue;
                if (Stats.RoomsStatistic.ContainsKey(roomType)) {
                    Stats.RoomsStatistic[roomType] += offer.Hotel.OfferRoomCounts.GetCountForType(roomType);
                }
                else
                {
                    Stats.RoomsStatistic.Add(roomType, offer.Hotel.OfferRoomCounts.GetCountForType(roomType));
                }
                
            }

            // Add transport stats
            if (Stats.TransportTypeStatistic.ContainsKey(offer.TransportTo.TransportType))
            {
                Stats.TransportTypeStatistic[offer.TransportTo.TransportType]++;
            }
            else
            {
                Stats.TransportTypeStatistic.Add(offer.TransportTo.TransportType, 1);
            }

            // Add back transport
            if(Stats.TransportTypeStatistic.ContainsKey(offer.TransportBack.TransportType))
            {
                Stats.TransportTypeStatistic[offer.TransportBack.TransportType]++;
            }
            else
            {
                Stats.TransportTypeStatistic.Add(offer.TransportBack.TransportType, 1);
            }
        }

        public static void RemoveOffer(Offer offer)
        {
            if (Stats == null)
                return;
            // Remove destivation stats
            if (Stats.DestinationStats.ContainsKey(offer.TransportTo.To))
            {
                Stats.DestinationStats[offer.TransportTo.To]--;
                if (Stats.DestinationStats[offer.TransportTo.To] <= 0)
                {
                    Stats.DestinationStats.Remove(offer.TransportTo.To);
                }
            }

            // Remove hotel stats
            if (Stats.HotelsStatistic.ContainsKey(offer.Hotel.HotelId))
            {
                Stats.HotelsStatistic[offer.Hotel.HotelId]--;
                if (Stats.HotelsStatistic[offer.Hotel.HotelId] <= 0)
                {
                    Stats.HotelsStatistic.Remove(offer.Hotel.HotelId);
                }
            }

            // Remove room stats
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                if (roomType == RoomType.None)
                    continue;
                if (Stats.RoomsStatistic.ContainsKey(roomType))
                    Stats.RoomsStatistic[roomType] -= offer.Hotel.OfferRoomCounts.GetCountForType(roomType);
                if (Stats.RoomsStatistic[roomType] < 0)
                    Stats.RoomsStatistic[roomType] = 0;
            }

            // Remove transport stats
            if (Stats.TransportTypeStatistic.ContainsKey(offer.TransportTo.TransportType))
            {
                Stats.TransportTypeStatistic[offer.TransportTo.TransportType]--;
                if (Stats.TransportTypeStatistic[offer.TransportTo.TransportType] <= 0)
                {
                    Stats.TransportTypeStatistic.Remove(offer.TransportTo.TransportType);
                }
            }

            if (Stats.TransportTypeStatistic.ContainsKey(offer.TransportBack.TransportType))
            {
                Stats.TransportTypeStatistic[offer.TransportBack.TransportType]--;
                if (Stats.TransportTypeStatistic[offer.TransportBack.TransportType] <= 0)
                {
                    Stats.TransportTypeStatistic.Remove(offer.TransportBack.TransportType);
                }
            }
        }
    }
}
