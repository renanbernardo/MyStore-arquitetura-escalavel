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
            _connectionStringMyStore = root.GetSection("ConnectionString").GetSection("MyStoreConnectionString").Value;
            var appSetting = root.GetSection("ApplicationSettings");
        }

        public string ConnectionStringMyStore
        {
            get => _connectionStringMyStore;
        }
    }
}
