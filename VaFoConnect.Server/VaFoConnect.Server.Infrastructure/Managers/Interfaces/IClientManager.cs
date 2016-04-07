using System.Collections.Generic;
using VaFoConnect.Server.Infrastructure.Models;

namespace VaFoConnect.Server.Infrastructure.Managers.Interfaces
{
    public interface IClientManager
    {
        void AddClient(Client client);
        IEnumerable<Client> GetClients();
    }
}