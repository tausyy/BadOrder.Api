namespace BadOrder.Api.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConnectionString => $"mongodb://{Name}:{Password}@{Host}:{Port}";
    }
}