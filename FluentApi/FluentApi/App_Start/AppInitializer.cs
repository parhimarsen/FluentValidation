using FluentApi.Domain.Interfaces;
using System.Web.Http;

namespace FluentApi.App_Start
{
    public static class AppInitializer
    {
        public static void Initialize()
        {
            using (var scope = GlobalConfiguration.Configuration.DependencyResolver.BeginScope())
            {
                var service = (IDomainInitializationService)scope.GetService(typeof(IDomainInitializationService));

                service.Initialize();
            }
        }
    }
}