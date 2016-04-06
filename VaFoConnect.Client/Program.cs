using VaFoConnect.Client.Infrastructure.Configurations;
using VaFoConnect.Client.Infrastructure.Managers;
using VaFoConnect.Core.Infrastructure.Providers;

namespace VaFoConnect.Client.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("-----=====[ VaFoConnect ]=====-----");
            System.Console.WriteLine("-----=====[     v0.1    ]=====-----");

            Initialize();
            var instanceProvider = InstanceProvider.GetInstanceProvider();

            var clientManager = instanceProvider.GetInstance<ClientManager>();
            clientManager.ShowClients();
            //TODO: Run ClientManager

            System.Console.ReadKey();
        }

        private static void Initialize()
        {
            InstanceProvider.GetInstanceProvider().Register(ContainerConfigurator.Configure);
        }
    }
}
