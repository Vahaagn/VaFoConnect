using VaFoConnect.Core.Infrastructure.Entities.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Providers.Interfaces
{
    public interface ISettingsProvider
    {
        ISettings GetSettings();
        ISettingsProvider Load();
        bool Save();
    }
}