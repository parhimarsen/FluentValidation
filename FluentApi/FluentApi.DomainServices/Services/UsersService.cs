using System.Collections.Generic;
using System.Linq;
using FluentApi.Domain.Interfaces;
using FluentApi.Domain.Models;
using FluentApi.DomainServices.Mappers;
using FluentApi.Infrastructure.Interfaces;

namespace FluentApi.DomainServices.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public IEnumerable<DomainUser> SearchAllUsers()
        {
            var users = _usersRepository.GetAllUsers();

            return users.Select(_ => _?.ToDomain()).ToList();
        }

        public DomainUser SearchUser(int userId)
        {
            return _usersRepository.GetUser(userId)?.ToDomain();
        }

        public IEnumerable<DomainDevice> SearchAllDevicesOfUser(int userId)
        {
            var devicesOfUser = _usersRepository.GetAllDevicesOfUser(userId);

            return devicesOfUser.Select(_ => _?.ToDomain()).ToList();
        }

        public DomainDevice SearchDeviceOfUser(int userId, int deviceId)
        {
            return _usersRepository.GetDeviceOfUser(userId, deviceId)?.ToDomain();
        }
    }
}
