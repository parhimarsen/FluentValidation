using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApi.Domain.Interfaces;
using FluentApi.DomainServices.Services;
using Microsoft.Practices.Unity;

namespace FluentApi.IoC.Modules
{
    public class DomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDomainInitializationService, DomainInitializationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsersService, UsersService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDevicesService, DevicesService>(new HierarchicalLifetimeManager());
            container.RegisterType<IQueriesService, QueriesService>(new HierarchicalLifetimeManager());
        }
    }
}
