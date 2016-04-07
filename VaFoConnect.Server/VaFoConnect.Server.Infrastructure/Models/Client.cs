using System;
using System.Net.Sockets;
using VaFoConnect.Core.Infrastructure.Entities;

namespace VaFoConnect.Server.Infrastructure.Models
{
    public class Client : User
    {
        public Guid Guid { get; private set; }
        public TcpClient TcpClient { get; private set; }

        public Client(TcpClient tcpClient)
        {
            Guid = Guid.NewGuid();
            TcpClient = tcpClient;
        }
    }
}