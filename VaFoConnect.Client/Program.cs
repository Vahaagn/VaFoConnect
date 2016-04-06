using VaFoConnect.Client.Infrastructure.Managers;

namespace VaFoConnect.Client.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("-----=====[ VaFoConnect ]=====-----");
            System.Console.WriteLine("-----=====[     v0.1    ]=====-----");

            ClientManager clientManager = new ClientManager();
            //TODO: Run ClientManager

            System.Console.ReadKey();
        }
    }
}
