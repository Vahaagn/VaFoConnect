using VaFoConnect.Core.Infrastructure.Entities;
using VaFoConnect.Core.Infrastructure.Entities.Interfaces;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Providers
{
    public class SettingsProvider : ISettingsProvider
    {
        private readonly ISettings _settings;

        public SettingsProvider(ISettings settings)
        {
            _settings = settings;
        }

        public ISettings GetSettings()
        {
            return _settings;
        }

        public void Load()
        {
            var settings = (Settings) _settings;

            settings.IpAddress = "127.0.0.1";
            settings.Port = 5000;
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }
    }
}