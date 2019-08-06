using FluentApi.Infrastructure.Interfaces;
using FluentApi.InfrastructureServices.Contexts;
using FluentApi.InfrastructureServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using System.Configuration;
using FluentApi.InfrastructureServices.Services;

namespace FluentApi.IoC.Modules
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionBuilder.Options)) context.Database.EnsureCreated();

            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(),
                new InjectionConstructor(optionBuilder.Options));

            container.RegisterType<IDataProvider, DataProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<IMyContextInitializationService, MyContextInitializationService>(
                new HierarchicalLifetimeManager());
            container.RegisterType<IUsersRepository, UsersRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDevicesRepository, DevicesRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IQueryRepository, QuerysRepository>(new HierarchicalLifetimeManager());
        }
    }
}
