using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using VaFoConnect.Core.Infrastructure.Entities.Interfaces;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;
using VaFoConnect.Server.Infrastructure.EventsArgs;
using VaFoConnect.Server.Infrastructure.Managers.Interfaces;
using VaFoConnect.Server.Infrastructure.Models;
using VaFoConnect.Server.Infrastructure.Services.Interfaces;

namespace VaFoConnect.Server.Infrastructure.Services
{
    public class SocketService : ISocketService
    {
        #region [ Fields ]
        private readonly TcpListener _tcpListener;
        private readonly IClientManager _clientManager;
        private readonly ISettings _settings;
        private bool _canListen = false;
        #endregion

        #region [ Properties ]
        public bool IsListening => _canListen;
        #endregion

        #region [ Constructors ]
        public SocketService(ISettingsProvider settingsProvider, IClientManager clientManager)
        {
            _settings = settingsProvider.Load().GetSettings();
            _clientManager = clientManager;
            _tcpListener = new TcpListener(_settings.IpAddress, _settings.Port);
        }
        #endregion
        
        #region [ Events ]
        public event EventHandler<ClientConnectedEventArgs> ClientConnected;
        #endregion

        #region [ Public methods ]
        public void StartListening()
        {
            try
            {
                _canListen = true;
                _tcpListener.Start();
                Listen().Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void StopListening()
        {
            _canListen = false;
        }
        #endregion

        #region [ Private methods ]
        private Task Listen()
        {
            return new Task(ListenAction());
        }

        private Action ListenAction()
        {
            return () =>
            {
                while (_canListen)
                {
                    var tcpClient = _tcpListener.AcceptTcpClient();
                    var client = new Client(tcpClient);
                    _clientManager.AddClient(client);

                    ClientConnected?.Invoke(this, new ClientConnectedEventArgs(client));
                }
            };
        }
        #endregion
    }
}