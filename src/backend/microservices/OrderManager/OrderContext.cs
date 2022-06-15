using MongoDB.Driver;
using Shared.Config;
using Shared.DataModels.Order;

namespace OrderManager
{
    public class OrderContext
    {
        private readonly IMongoDatabase _database;
        public readonly IMongoCollection<Order> OrderCollection;

        public OrderContext()
        {
            var client = new MongoClient(MongoDbSettings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(MongoDbSettings.Database);
                _database.DropCollection(MongoDbSettings.Collection);
                OrderCollection = _database.GetCollection<Order>(MongoDbSettings.Collection);
            }
        }
    }
}
