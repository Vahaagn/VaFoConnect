using System;
using VaFoConnect.Server.Infrastructure.EventsArgs;

namespace VaFoConnect.Server.Infrastructure.Services.Interfaces
{
    public interface ISocketService
    {
        bool IsListening { get; }

        event EventHandler<ClientConnectedEventArgs> ClientConnected;

        void StartListening();
        void StopListening();
    }
}