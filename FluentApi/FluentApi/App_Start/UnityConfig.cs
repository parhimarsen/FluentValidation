using Microsoft.Practices.Unity;
using System.Web.Http;
using FluentApi.Interfaces;
using FluentApi.IoC;
using FluentApi.IoC.Modules;
using FluentApi.Services;
using Unity.WebApi;

namespace FluentApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            Register<DomainModule>(container);
            Register<InfrastructureModule>(container);
            container.RegisterType<IExceptionLogger, ExceptionLogger>(new HierarchicalLifetimeManager());
            container.RegisterType<IRequestLogger, RequestLogger>(new HierarchicalLifetimeManager());

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T: IModule, new()
        {
            new T().Register(container);
        }
    }
}