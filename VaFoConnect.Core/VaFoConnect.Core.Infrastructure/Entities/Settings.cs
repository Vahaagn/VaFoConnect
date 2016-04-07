using VaFoConnect.Core.Infrastructure.Entities.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Entities
{
    public class Settings : ISettings
    {
        public string IpAddress { get; set; } 
        public int Port { get; set; }
    }
}