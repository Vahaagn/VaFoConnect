using VaFoConnect.Core.Infrastructure.Providers;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Configurations
{
    public static class ContainerConfigurator
    {
        public static void Configure(InstanceProvider instanceProvider)
        {
            RegisterComponents(instanceProvider);
        }

        private static void RegisterComponents(IInstanceProvider instanceProvider)
        {
            RegisterProviders(instanceProvider);
            RegisterManagers(instanceProvider);
            RegisterServices(instanceProvider);
        }

        private static void RegisterProviders(IInstanceProvider instanceProvider)
        {

        }

        private static void RegisterManagers(IInstanceProvider instanceProvider)
        {
            
        }

        private static void RegisterServices(IInstanceProvider instanceProvider)
        {
            
        }
    }
}