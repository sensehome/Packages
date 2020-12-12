using MongoDB.Driver;

namespace SenseHome.DB.Mongo
{
    public class MongoDBContext
    {
        public readonly IMongoClient Client;
        public readonly IMongoDatabase Database; //default database from settings
        
        public MongoDBContext(MongoDBSettings settings)
        {
            Client = new MongoClient(settings.Host);
            Database = Client.GetDatabase(settings.Name);
        }
    }
}
