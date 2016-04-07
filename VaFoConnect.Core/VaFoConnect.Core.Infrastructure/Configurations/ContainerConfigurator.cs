using VaFoConnect.Core.Infrastructure.Entities;
using VaFoConnect.Core.Infrastructure.Entities.Interfaces;
using VaFoConnect.Core.Infrastructure.Providers;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Configurations
{
    public static class ContainerConfigurator
    {
        public static void Configure(IInstanceProvider instanceProvider)
        {
            RegisterComponents(instanceProvider);
        }

        private static void RegisterComponents(IInstanceProvider instanceProvider)
        {
            RegisterEntities(instanceProvider);
            RegisterProviders(instanceProvider);
            RegisterManagers(instanceProvider);
            RegisterServices(instanceProvider);
        }

        private static void RegisterEntities(IInstanceProvider instanceProvider)
        {
            instanceProvider.Assign<ISettings, Settings>();
        }

        private static void RegisterProviders(IInstanceProvider instanceProvider)
        {
            instanceProvider.Assign<ISettingsProvider, SettingsProvider>();
        }

        private static void RegisterManagers(IInstanceProvider instanceProvider)
        {
            
        }

        private static void RegisterServices(IInstanceProvider instanceProvider)
        {
            
        }
    }
}