namespace VaFoConnect.Core.Infrastructure.Entities.Interfaces
{
    public interface ISettings
    {
        string IpAddress { get; }
        int Port { get; }
    }
}