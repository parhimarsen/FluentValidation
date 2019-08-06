using FluentApi.Infrastructure.Models;
using System.Collections.Generic;

namespace FluentApi.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<InfrastructureUser> GetAllUsers();

        InfrastructureUser GetUser(int userId);

        IEnumerable<InfrastructureDevice> GetAllDevicesOfUser(int userId);

        InfrastructureDevice GetDeviceOfUser(int userId, int deviceId);

    }
}
