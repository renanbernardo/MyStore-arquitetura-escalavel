using Microsoft.Extensions.Configuration;

namespace MyStore.Infra.AppConfig
{
    public class AppConfiguration
    {
        public readonly string _connectionStringMyStore = string.Empty;
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            root.GetSection("ApplicationSettings");
            _connectionStringMyStore = root.GetSection("ConnectionStrings").GetSection("MyStoreConnectionString").Value;
        }

        public string ConnectionStringMyStore
        {
            get => _connectionStringMyStore;
        }
    }
}
