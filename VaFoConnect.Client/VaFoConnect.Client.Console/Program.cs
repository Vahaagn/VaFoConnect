using VaFoConnect.Client.Infrastructure;
using VaFoConnect.Client.Infrastructure.Managers.Interfaces;
using VaFoConnect.Core.Infrastructure.Providers;

namespace VaFoConnect.Client.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("-----=====[ VaFoConnect ]=====-----");
            System.Console.WriteLine("-----=====[     v0.1    ]=====-----");
            
            var instanceProvider = InstanceProvider.GetInstanceProvider().Initialize();

            var clientManager = instanceProvider.GetInstance<IClientManager>();
            clientManager.ShowClients();
            //TODO: Run ClientManager

            System.Console.ReadKey();
        }
    }
}
