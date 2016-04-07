using System;
using System.Net.Sockets;
using VaFoConnect.Core.Infrastructure.Entities;

namespace VaFoConnect.Server.Infrastructure.Models
{
    public class Client : User
    {
        public Guid Guid { get; private set; }
        public Socket Socket { get; private set; }

        public Client(Socket socket)
        {
            Guid = Guid.NewGuid();
            Socket = socket;
        }
    }
}