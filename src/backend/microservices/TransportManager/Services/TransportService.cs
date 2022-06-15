using MongoDB.Driver;
using Shared.DataModels.Offer;
using Shared.DataModels.Transport;

namespace TransportManager.Services
{
    public class TransportService
    {
        private readonly TransportContext _context;

        public TransportService(TransportContext context)
        {
            _context = context;
        }

        public List<TransportDataModel> GetAllTransports()
        {
            return _context.TransportCollection.Find(x => true).ToList();
        }

        public TransportDataModel GetTransport(int id)
        {
            return _context.TransportCollection.Find(x => x.Id == id).FirstOrDefault();
        }
        public void AddTransport(TransportDataModel transport)
        {
            _context.TransportCollection.InsertOne(transport);
        }

        public void RemoveTransport(int id)
        {
            _context.TransportCollection.DeleteOne(x => x.Id == id);
        }

        public void UpdateTransport(TransportDataModel transport)
        {
            _context.TransportCollection.ReplaceOne(x => x.Id == transport.Id, transport);
        }

        public void UpdateTransportPrice(int id, int price)
        {
            var filter = Builders<TransportDataModel>.Filter.Where(x => x.Id == id);
            var update = Builders<TransportDataModel>.Update.Set(x => x.Price, price);
            var result = _context.TransportCollection.UpdateOne(filter, update);
        }

        public void UpdateTransportAvailableSeats(int id, int newAvailableSeats)
        {
            var filter = Builders<TransportDataModel>.Filter.Where(x => x.Id == id);
            var update = Builders<TransportDataModel>.Update.Set(x => x.AllSeats, newAvailableSeats);
            var result = _context.TransportCollection.UpdateOne(filter, update);
        }

        public List<TransportDataModel> GetAllTransportsFiltered(TransportOfferFilter userTransportOfferFilter)
        {
            return _context.TransportCollection.Find(x => true).ToList();
        }

        public IEnumerable<TransportOffer> GetTransportOffers(TransportOfferFilter filter)
        {
            var transports = _context.TransportCollection.Find(filter.toMongoFilter()).ToList();
            var transportOffers = transports.Select(x => new TransportOffer
            {
                TransportId = x.Id,
                DateTime = x.DateTime,
                From = x.From,
                To = x.To,
                Price = x.CalculatePrice(filter.RequiredSeats),
                NumberOfSeats = filter.RequiredSeats,
                TransportType = x.Type
            });
            return transportOffers;
        }

        internal TransportOffer? RefreshTransportOffer(TransportOffer transportOffer)
        {
            var transport = _context.TransportCollection.Find(x => x.Id == transportOffer.TransportId).FirstOrDefault();
            if (transport == null || transport.AvailableSeats < transportOffer.NumberOfSeats)
            {
                return null;
            }

            transportOffer.Price = transport.CalculatePrice(transportOffer.NumberOfSeats);
            return transportOffer;
        }

        internal bool IsTransportOfferAvailable(TransportOffer transportOffer)
        {
            var transport = _context.TransportCollection.Find(x => x.Id == transportOffer.TransportId).FirstOrDefault();
            if (transport == null)
            {
                return true;
            }

            return transport.AvailableSeats >= transportOffer.NumberOfSeats;
        }
        public Tuple<bool,Guid> ReserveTransport(int id, int numberOfPersons)
        {
            var transport = _context.TransportCollection.Find(x => x.Id == id).FirstOrDefault();
            
            if (transport == null)
            {
                return new Tuple<bool, Guid>(false, Guid.Empty);
            }
            var reservedSeats = CalculateReservedSeats(id);
            if (transport.AllSeats - reservedSeats < numberOfPersons)
            {
                return new Tuple<bool, Guid>(false, Guid.Empty);
            }

            transport.AvailableSeats -= numberOfPersons;
            var orderGuid = Guid.NewGuid();
            _context.TransportEvents.InsertOne(new TransportEvent
            {
                SeatsReserved = numberOfPersons,
                TransportId = id,
                EventType = EventType.Reserved,
                OrderId = orderGuid
            });
            _context.TransportCollection.ReplaceOneAsync(x => x.Id == id, transport);
            return new Tuple<bool, Guid>(true, orderGuid);
        }

        public int CancelReservation(int id, int numberOfPersons, Guid orderGuid)
        {
            var transport = _context.TransportCollection.Find(x => x.Id == id).FirstOrDefault();
            _context.TransportEvents.InsertOne(new TransportEvent
            {
                SeatsReserved = numberOfPersons,
                TransportId = id,
                EventType = EventType.Cancelled,
                OrderId = orderGuid
            });
            if (transport == null)
            {
                return -1;
            }

            if (transport.AvailableSeats + numberOfPersons > transport.AllSeats)
            {
                return -2;
            }

            transport.AvailableSeats += numberOfPersons;
            _context.TransportCollection.ReplaceOneAsync(x => x.Id == id, transport);
            return 0;
        }

        public List<string> GetAllLocations()
        {
            return _context.TransportCollection.Find(x => true).ToList().Select(x => x.To).Distinct().ToList();
        }

        public int CalculateReservedSeats(int id)
        {
            var transport = _context.TransportEvents.Find(x => x.TransportId == id).ToList();
            if (transport.Count == 0)
            {
                return 0;
            }
            
            // Group transport events by OrderId
            var groupedTransportEvents = transport.GroupBy(x => x.OrderId);
            // From each group, check if it has cancelled event, if not, add it to the sum
            var reservedSeats = groupedTransportEvents.Sum(x => x.Any(x => x.EventType == EventType.Cancelled) ? 0 : x.First().SeatsReserved);
            return reservedSeats;
        }
    }
}
