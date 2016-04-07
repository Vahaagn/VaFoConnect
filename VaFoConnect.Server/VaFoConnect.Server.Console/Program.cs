using System.Linq;
using VaFoConnect.Core.Infrastructure.Providers;
using VaFoConnect.Server.Infrastructure.Configurations;
using VaFoConnect.Server.Infrastructure.Managers.Interfaces;
using VaFoConnect.Server.Infrastructure.Models;
using VaFoConnect.Server.Infrastructure.Services.Interfaces;

namespace VaFoConnect.Server.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("-----=====[ VaFoConnect ]=====-----");
            System.Console.WriteLine("-----=====[     v0.1    ]=====-----");

            var instanceProvider = InstanceProvider.GetInstanceProvider().Initialize();
            var socketService = instanceProvider.GetInstance<ISocketService>();
            socketService.ClientConnected += (sender, eventArgs) =>
            {
                System.Console.WriteLine($"-----\n# Client connected!\n# {eventArgs.Guid}\n-----");
            };

            System.Console.WriteLine("Starting...");
            socketService.StartListening();
            System.Console.WriteLine("Started!\nListening...");
            
            System.Console.WriteLine("Press any key to stop...");
            System.Console.ReadKey();
        }
    }
}
