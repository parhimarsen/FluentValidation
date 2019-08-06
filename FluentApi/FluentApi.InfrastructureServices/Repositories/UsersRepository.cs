using FluentApi.Infrastructure.Interfaces;
using FluentApi.Infrastructure.Models;
using FluentApi.InfrastructureServices.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace FluentApi.InfrastructureServices.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly MyContext _context;

        public UsersRepository(MyContext context)
        {
            _context = context;
        }

        public IEnumerable<InfrastructureUser> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public InfrastructureUser GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(_ => _.Id == userId);
        }

        public IEnumerable<InfrastructureDevice> GetAllDevicesOfUser(int userId)
        {
            return _context.Devices.Where(_ => _.UserId == userId);
        }

        public InfrastructureDevice GetDeviceOfUser(int userId, int deviceId)
        {
            return GetAllDevicesOfUser(userId).FirstOrDefault(_ => _.Id == deviceId);
        }
    }
}
