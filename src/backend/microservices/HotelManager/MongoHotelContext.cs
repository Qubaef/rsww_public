using MongoDB.Driver;
using Shared.Config;
using Shared.DataModels.Hotel;

namespace HotelManager
{
    public class MongoHotelContext
    {
        private readonly IMongoDatabase _database;
        public readonly IMongoCollection<HotelEvent> HotelEvents;

        public MongoHotelContext()
        {
            var client = new MongoClient(MongoDbSettings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(MongoDbSettings.Database);
                _database.DropCollection(MongoDbSettings.Collection);
                HotelEvents = _database.GetCollection<HotelEvent>(MongoDbSettings.Collection);
            }
        }
    }
}
