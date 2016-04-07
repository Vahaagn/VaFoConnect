using System;
using System.Net.Sockets;
using VaFoConnect.Server.Infrastructure.Models;

namespace VaFoConnect.Server.Infrastructure.EventsArgs
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public Guid Guid { get; private set; }
        public Client Client { get; private set; }

        public ClientConnectedEventArgs(Client client)
        {
            Guid = Guid.NewGuid();
            Client = client;
        }
    }
}