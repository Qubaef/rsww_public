using MongoDB.Driver;
using Shared.Config;
using Shared.DataModels.Transport;

namespace TransportManager
{
    public class TransportContext
    {
        private readonly IMongoDatabase _database;
        public readonly IMongoCollection<TransportDataModel> TransportCollection;
        public readonly IMongoCollection<TransportEvent> TransportEvents;
        public TransportContext()
        {
            var client = new MongoClient(MongoDbSettings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(MongoDbSettings.Database);
                _database.DropCollection(MongoDbSettings.Collection);
                _database.DropCollection(MongoDbSettings.EventCollection);
                TransportCollection = _database.GetCollection<TransportDataModel>(MongoDbSettings.Collection);
                TransportEvents = _database.GetCollection<TransportEvent>(MongoDbSettings.EventCollection);
            }
        }
    }
}