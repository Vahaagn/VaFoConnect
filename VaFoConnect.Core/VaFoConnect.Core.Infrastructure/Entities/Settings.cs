using System.Net;
using VaFoConnect.Core.Infrastructure.Entities.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Entities
{
    public class Settings : ISettings
    {
        public string Ip { get; set; }
        public IPAddress IpAddress => IPAddress.Parse(Ip);
        public int Port { get; set; }
    }
}