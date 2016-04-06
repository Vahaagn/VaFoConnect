using System.Collections.Generic;

namespace VaFoConnect.Core.Infrastructure.Providers.Interfaces
{
    public interface IInstanceProvider
    {
        void Assign<TService, TImplement>();
        TService GetInstance<TService>();
        IEnumerable<TService> GetAllInstances<TService>();
    }
}