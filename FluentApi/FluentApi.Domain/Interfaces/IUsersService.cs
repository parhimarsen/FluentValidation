using FluentApi.Domain.Models;
using System.Collections.Generic;

namespace FluentApi.Domain.Interfaces
{
    public interface IUsersService
    {
        IEnumerable<DomainUser> SearchAllUsers();

        DomainUser SearchUser(int userId);

        IEnumerable<DomainDevice> SearchAllDevicesOfUser(int userId);

        DomainDevice SearchDeviceOfUser(int userId, int deviceId);
    }
}
