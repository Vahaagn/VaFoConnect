using System;
using System.Collections.Generic;
using SimpleInjector;
using VaFoConnect.Core.Infrastructure.Configurations;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;

namespace VaFoConnect.Core.Infrastructure.Providers
{
    public class InstanceProvider : IInstanceProvider
    {
        #region [ Fields ]
        private static InstanceProvider _instanceProvider;
        private readonly Container _container;
        #endregion

        private InstanceProvider()
        {
            _container = new Container();
            ContainerConfigurator.Configure(this);
        }

        public static InstanceProvider GetInstanceProvider()
            => _instanceProvider ?? (_instanceProvider = new InstanceProvider());

        public void Register(Action<InstanceProvider> configurator)
        {
            configurator(this);
        }

        public void Assign<TService, TImplement>()
        {
            _container.Register(typeof(TService), typeof(TImplement));
        }

        public TService GetInstance<TService>()
        {
            try
            {
                return (TService)_container.GetInstance(typeof(TService));
            }
            catch (ActivationException)
            {
                // TODO: Log somewhere that no instance was found!
                return default(TService);
            }
        }

        public IEnumerable<TService> GetAllInstances<TService>()
        {
            try
            {
                return (IEnumerable<TService>)_container.GetAllInstances(typeof(TService));
            }
            catch (ActivationException)
            {
                // TODO: Log somewhere that no instance was found!
                return default(IEnumerable<TService>);
            }
        }
    }
}