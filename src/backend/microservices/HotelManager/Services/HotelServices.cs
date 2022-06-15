using MongoDB.Driver;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;

namespace HotelManager.Services
{
    public class HotelServices
    {
        private readonly HotelContext _context;
        private readonly MongoHotelContext _mongoContext;
        private readonly Dictionary<RoomType, RoomTypeStaticData> roomTypeDefinition;
        public HotelServices(HotelContext context, MongoHotelContext mongoContext)
        {
            this._context = context;
            this._mongoContext = mongoContext;
            roomTypeDefinition = new RoomDefiner().roomTypeDefinition;
        }

        // 
        public List<int> GetAllHotelsMinimal()
        {
            return _context.Hotels.Select(u => u.Id).ToList();
        }

        public List<RoomReservation> GetRoomReservations()
        {
            return _context.RoomReservation.ToList();
        }

        public List<HotelStaticData> GetAllHotelsFull()
        {
            var hotels = _context.Hotels.ToList();
            return hotels;
        }

        public List<HotelStaticData> GetAllHotelsFull(string destination)
        {
            var hotels = _context.Hotels.Where(hotel => hotel.City.ToLower() == destination.ToLower()).ToList();
            return hotels;
        }

        public HotelStaticData GetHotelByIdFull(int Id)
        {
            return _context.Hotels.FirstOrDefault(hotel => hotel.Id == Id);
        }

        public void CreateHotel(HotelStaticData hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public bool UpdateHotelPrice(int id, int price)
        {
            var hotel = _context.Hotels.FirstOrDefault(hotel => hotel.Id == id);
            if (hotel == null)
            {
                return false;
            }

            hotel.BasePrice = price;
            _context.SaveChanges();
            return true;
        }

        public bool UpdateHotelRoomCount(int id, RoomType type, int newCount)
        {
            var hotel = _context.Hotels.FirstOrDefault(hotel => hotel.Id == id);
            if (hotel == null)
            {
                return false;
            }

            hotel.RoomCounts.SetCountForType(type, newCount);
            _context.SaveChanges();
            return true;
        }

        internal HotelOffer? RefreshHotelOffer(HotelOffer hotelOffer)
        {
            var hotel = _context.Hotels.FirstOrDefault(x => x.Id == hotelOffer.HotelId);
            if (hotel == null)
            {
                return null;
            }

            var hotelRoomsDict = hotel.RoomCounts.toDictionary();
            var hotelOfferRoomsDict = hotelOffer.OfferRoomCounts.toDictionary();

            foreach (RoomType roomType in hotelRoomsDict.Keys)
            {
                if (hotelRoomsDict[roomType] < hotelOfferRoomsDict[roomType])
                {
                    return null;
                }
            }

            return new HotelOffer
            {
                HotelId = hotel.Id,
                From = hotelOffer.From,
                To = hotelOffer.To,
                Price = CalculatePrice(hotel, hotelOffer.OfferRoomCounts),
                OfferRoomCounts = hotelOffer.OfferRoomCounts
            };

        }

        public bool RemoveHotel(int Id)
        {
            var entity = _context.Hotels.FirstOrDefault(x => x.Id == Id);
            if (entity != null)
            {
                _context.Hotels.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        internal bool IsHotelOfferAvailable(HotelOffer hotelOffer)
        {
            var hotel = _context.Hotels.FirstOrDefault(x => x.Id == hotelOffer.HotelId);
            if (hotel == null)
            {
                return false;
            }

            var hotelRoomsDict = hotel.RoomCounts.toDictionary();
            var hotelOfferRoomsDict = hotelOffer.OfferRoomCounts.toDictionary();

            foreach (RoomType roomType in hotelRoomsDict.Keys)
            {
                if (hotelRoomsDict[roomType] < hotelOfferRoomsDict[roomType])
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }

        // Return hotel available rooms count for giver period
        private RoomCounts GetAllAvailableRoomsCounts(HotelStaticData hotel, DateTime startDate, DateTime endDate, List<RoomReservation> releventOrders)
        {
            var availableCount = new RoomCounts
            {
                Apartment = hotel.RoomCounts.Apartment,
                Small = hotel.RoomCounts.Small,
                Medium = hotel.RoomCounts.Medium,
                Large = hotel.RoomCounts.Large,
                Studio = hotel.RoomCounts.Studio
            };
            if (releventOrders.Count == 0)
            {
                return availableCount;
            }

            foreach (var day in EachDay(startDate, endDate))
            {
                // Get all orders for the day
                var orders = releventOrders.Where(r => r.HotelOffer.From <= day && r.HotelOffer.To >= day).ToList();
                // Calculate all reserved rooms
                var reservedRooms = new RoomCounts
                {
                    Apartment = 0,
                    Small = 0,
                    Medium = 0,
                    Large = 0,
                    Studio = 0
                };
                foreach (var order in orders)
                {
                    foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
                    {
                        if (roomType != RoomType.None)
                        {
                            reservedRooms.SetCountForType(roomType, reservedRooms.GetCountForType(roomType) + order.HotelOffer.OfferRoomCounts.GetCountForType(roomType));
                        }
                    }
                }

                foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
                {
                    if (roomType != RoomType.None)
                    {
                        if (reservedRooms.GetCountForType(roomType) > hotel.RoomCounts.GetCountForType(roomType) - availableCount.GetCountForType(roomType))
                        {
                            availableCount.SetCountForType(roomType, hotel.RoomCounts.GetCountForType(roomType) - reservedRooms.GetCountForType(roomType));
                        }
                    }
                }
            }
            return availableCount;
        }

        // Calculate remaining beds
        private int CalculateRemainingBeds(RoomTypeStaticData type, HotelOfferFilter hotelOfferFilter, int roomCount)
        {
            int rest = 0;
            rest += type.AdultBeds * roomCount - hotelOfferFilter.MinAdultsCount;
            if (rest < 0)
            {
                return -1;
            }

            rest += type.MinChildrenLT18Beds * roomCount - hotelOfferFilter.MinChildrenLT18Count;
            if (rest < 0)
            {
                return -1;
            }

            rest += type.MinChildrenLT10Beds * roomCount - hotelOfferFilter.MinChildrenLT10Count;
            if (rest < 0)
            {
                return -1;
            }

            rest += type.MinChildrenLT3Beds * roomCount - hotelOfferFilter.MinChildrenLT3Count;
            if (rest < 0)
            {
                return -1;
            }

            return rest;
        }

        // Remove from offer people, that has beds
        private void RemoveUsedBeds(RoomTypeStaticData type, HotelOfferFilter hotelOfferFilter, int roomCount)
        {
            int rest = 0;
            // Adults
            rest += hotelOfferFilter.MinAdultsCount - type.AdultBeds * roomCount;
            if (rest >= 0)
            {
                hotelOfferFilter.MinAdultsCount = rest;
                rest = 0;
            }
            else
            {
                hotelOfferFilter.MinAdultsCount = 0;
            }

            // T18
            rest += hotelOfferFilter.MinChildrenLT18Count - (type.MinChildrenLT18Beds * roomCount - rest);
            if (rest >= 0)
            {
                hotelOfferFilter.MinChildrenLT18Count = rest;
                rest = 0;
            }
            else
            {
                hotelOfferFilter.MinChildrenLT18Count = 0;
            }

            // T10
            rest += hotelOfferFilter.MinChildrenLT10Count - (type.MinChildrenLT10Beds * roomCount - rest);
            if (rest >= 0)
            {
                hotelOfferFilter.MinChildrenLT10Count = rest;
                rest = 0;
            }
            else
            {
                hotelOfferFilter.MinChildrenLT10Count = 0;
            }

            // T3
            rest += hotelOfferFilter.MinChildrenLT3Count - (type.MinChildrenLT3Beds * roomCount - rest);
            if (rest >= 0)
            {
                hotelOfferFilter.MinChildrenLT3Count = rest;
            }
            else
            {
                hotelOfferFilter.MinChildrenLT3Count = 0;
            }
        }

        // Calculate number of rooms each type, that satisfy offers
        private int CalculateRoomCount(RoomCounts availableRooms, HotelOfferFilter hotelOfferFilter, RoomType type)
        {
            int roomCountInHotel = availableRooms.GetCountForType(type);
            int answer = -1;
            for (int i = roomCountInHotel; i >= 0; i--)
            {
                if (CalculateRemainingBeds(roomTypeDefinition[type], hotelOfferFilter, i) >= 0)
                {
                    answer = i;
                }
                else
                {
                    break;
                }
            }

            return answer;
        }

        // Find room configuration for our trip, null if it dies ot exist.
        private RoomCounts FindSuitableRooms(HotelStaticData hotel, HotelOfferFilter hotelOfferFilterInc)
        {
            var hotelOfferFilter = new HotelOfferFilter(hotelOfferFilterInc);
            var releventOrders = _context.RoomReservation.Where(
                    r => r.HotelId == hotel.Id &&
                         r.HotelOffer.To >= DateTime.SpecifyKind(hotelOfferFilter.StartDate, DateTimeKind.Utc) &&
                         r.HotelOffer.From <= DateTime.SpecifyKind(hotelOfferFilter.EndDate, DateTimeKind.Utc)).ToList();
            var avaialableRooms = GetAllAvailableRoomsCounts(hotel, hotelOfferFilter.StartDate, hotelOfferFilter.EndDate, releventOrders);
            // Find room configuration that satisfies the hotelOfferFilter
            var roomConfiguration = new RoomCounts();
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                if (roomType != RoomType.None)
                {
                    roomConfiguration.SetCountForType(roomType, 0);
                }
            }

            // Calculate how many rooms of given types is needed

            // If exist room type, which can handle all people, we use it

            // Studio - 2
            // Small - 3.

            // 
            while (avaialableRooms.FindLargestAvailable() != RoomType.None)
            {
                Dictionary<RoomType, int> RoomNeededOfEachType = new();


                foreach (RoomType type in Enum.GetValues(typeof(RoomType)))
                {
                    if (type != RoomType.None)
                    {
                        RoomNeededOfEachType.Add(type, CalculateRoomCount(avaialableRooms, hotelOfferFilter, type));
                    }
                }

                RoomNeededOfEachType = RoomNeededOfEachType.Where(x => x.Value > 0).ToDictionary(i => i.Key, i => i.Value);
                if (RoomNeededOfEachType.Count > 0)
                {
                    var type = RoomNeededOfEachType.MinBy(kvp => kvp.Value);
                    roomConfiguration.SetCountForType(type.Key, type.Value);
                    return roomConfiguration;
                }
                else
                {
                    var type = avaialableRooms.FindLargestAvailable();
                    var roomCount = avaialableRooms.GetCountForType(type);
                    roomConfiguration.SetCountForType(type, roomCount);
                    avaialableRooms.SetCountForType(type, 0);
                    RemoveUsedBeds(roomTypeDefinition[type], hotelOfferFilter, roomCount);
                }
            }

            return null;
        }

        public IEnumerable<HotelOffer> GetHotelOffers(HotelOfferFilter hotelOfferFilter)
        {
            var hotels = _context.Hotels.Where(hotel => hotel.City == hotelOfferFilter.Destination).ToList();
            List<HotelOffer> result = new();
            foreach (var hotel in hotels)
            {
                var roomConfiguration = FindSuitableRooms(hotel, hotelOfferFilter);

                if (roomConfiguration != null)
                {
                    result.Add(new HotelOffer
                    {
                        HotelId = hotel.Id,
                        From = hotelOfferFilter.StartDate,
                        To = hotelOfferFilter.EndDate,
                        Price = CalculatePrice(hotel, roomConfiguration),
                        OfferRoomCounts = roomConfiguration
                    });
                }
            }
            return result;
        }

        public int CalculatePrice(HotelStaticData hotel, RoomCounts roomConfiguration)
        {
            int price = 0;
            foreach (RoomType type in Enum.GetValues(typeof(RoomType)))
            {
                if (type != RoomType.None)
                {
                    price += roomConfiguration.GetCountForType(type) * roomTypeDefinition[type].PriceModifier;
                }
            }
            return price * hotel.BasePrice;
        }

        public RoomReservation? ReserveOffer(HotelOffer offer)
        {
            // Check availability
            var hotel = _context.Hotels.FirstOrDefault(x => x.Id == offer.HotelId);
            if (hotel == null)
            {
                return null;
            }
            var releventOrders = _mongoContext.HotelEvents.Find(
                    r => r.reservation.HotelId == hotel.Id &&
                         r.reservation.HotelOffer.To >= DateTime.SpecifyKind(offer.From, DateTimeKind.Utc) &&
                         r.reservation.HotelOffer.From <= DateTime.SpecifyKind(offer.To, DateTimeKind.Utc)).ToList();
            var groupedHotelEvents = releventOrders.GroupBy(x => x.reservation.Id);
            var orders = new List<RoomReservation>();
            // for each groupedHotelEvents, check if any order has eventType canclelled. If so, continue, else add roomReservation to orders
            foreach (var group in groupedHotelEvents)
            {
                var order = group.First().reservation;
                if (group.Any(x => x.eventType == EventType.Cancelled))
                {
                    continue;
                }
                else
                {
                    orders.Add(order);
                }
            }
            var availableRoom = GetAllAvailableRoomsCounts(hotel, offer.From, offer.To, orders);
            foreach (RoomType type in Enum.GetValues(typeof(RoomType)))
            {
                if (type != RoomType.None)
                {
                    if (availableRoom.GetCountForType(type) < offer.OfferRoomCounts.GetCountForType(type))
                    {
                        return null;
                    }
                }
            }

            offer.From = DateTime.SpecifyKind(offer.From, DateTimeKind.Utc);
            offer.To = DateTime.SpecifyKind(offer.To, DateTimeKind.Utc);
            RoomReservation reservation = new RoomReservation
            {
                HotelId = offer.HotelId,
                HotelOffer = offer
            };

            _context.RoomReservation.Add(reservation);
            _context.SaveChanges();

            HotelEvent hotelEvent = new HotelEvent
            {
                reservation = reservation,
                eventType = EventType.Reserved,
                Id = Guid.NewGuid()
            };
            _mongoContext.HotelEvents.InsertOne(hotelEvent);
            return reservation;
        }

        public void CancelReservation(RoomReservation reservation)
        {
            var order = _context.RoomReservation.FirstOrDefault(r => r.Id == reservation.Id);
            HotelEvent hotelEvent = new HotelEvent
            {
                reservation = reservation,
                eventType = EventType.Cancelled,
                Id = Guid.NewGuid()
            };
            _mongoContext.HotelEvents.InsertOne(hotelEvent);            
            if (order == null)
            {
                return;
            }

            _context.RoomReservation.Remove(order);
            _context.SaveChanges();
            return;
        }
    }
}
