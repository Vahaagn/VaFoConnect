using System.Collections.Generic;
using VaFoConnect.Server.Infrastructure.Managers.Interfaces;
using VaFoConnect.Server.Infrastructure.Models;

namespace VaFoConnect.Server.Infrastructure.Managers
{
    public class ClientManager : IClientManager
    {
        private readonly List<Client> _clients;

        public ClientManager()
        {
            _clients = new List<Client>();
        } 

        public void AddClient(Client client)
        {
            if (_clients.Exists(c => c.Guid.Equals(client.Guid)))
                return;

            _clients.Add(client);
        }

        public IEnumerable<Client> GetClients()
        {
            return _clients;
        }
    }
}