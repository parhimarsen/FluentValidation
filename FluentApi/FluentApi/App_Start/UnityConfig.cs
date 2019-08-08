using FluentApi.IoC;
using FluentApi.IoC.Modules;
using Microsoft.Practices.Unity;
using System.Web.Http;
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


            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            new T().Register(container);
        }
    }
}