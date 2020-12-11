namespace SenseHome.DB.Redis
{
    public class RedisDBSettings
    {
        public string Host { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public int DatabaseIndex { get; set; }

        public string GetConnectionString()
        {
            return $"{Host}:{Port},defaultDatabase={DatabaseIndex}";
        }
    }
}
