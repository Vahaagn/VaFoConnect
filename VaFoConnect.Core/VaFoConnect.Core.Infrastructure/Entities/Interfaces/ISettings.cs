using System.Net;

namespace VaFoConnect.Core.Infrastructure.Entities.Interfaces
{
    public interface ISettings
    {
        string Ip { get; }
        IPAddress IpAddress { get; }
        int Port { get; }
    }
}