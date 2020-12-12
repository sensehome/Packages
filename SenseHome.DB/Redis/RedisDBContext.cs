using StackExchange.Redis;

namespace SenseHome.DB.Redis
{
    public class RedisDBContext
    {
        public readonly IDatabase Database;
        public readonly IConnectionMultiplexer Connection;

        public RedisDBContext(RedisDBSettings settings)
        {
            Connection = ConnectionMultiplexer.Connect(settings.GetConnectionString());
            Database = Connection.GetDatabase();
        }
    }
}
