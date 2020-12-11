using StackExchange.Redis;

namespace SenseHome.DB.Redis
{
    public class RedisDBContext
    {
        public IDatabase Database;
        public RedisDBContext(RedisDBSettings settings)
        {
            var redis = ConnectionMultiplexer.Connect(settings.GetConnectionString());
            Database = redis.GetDatabase();
        }
    }
}
