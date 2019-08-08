using FluentApi.Infrastructure.Interfaces;
using FluentApi.InfrastructureServices.Contexts;

namespace FluentApi.InfrastructureServices.Services
{
    public class MyContextInitializationService : IMyContextInitializationService
    {
        private readonly MyContext _context;
        private readonly IDataProvider _provider;

        public MyContextInitializationService(MyContext context, IDataProvider provider)
        {
            _context = context;
            _provider = provider;
        }

        public void Initialize()
        {
            _context.Database.EnsureCreated();


            _context.Users.RemoveRange(_context.Users);
            _context.Users.AddRange(_provider.GetUsers());
            _context.SaveChanges();


            _context.Devices.RemoveRange(_context.Devices);
            _context.Devices.AddRange(_provider.GetDevices());
            _context.SaveChanges();

        }
    }
}
