using FluentApi.Infrastructure.Models;
using System.Collections.Generic;

namespace FluentApi.Infrastructure.Interfaces
{
    public interface IDataProvider
    {
        IList<InfrastructureUser> GetUsers();

        IList<InfrastructureDevice> GetDevices();
    }
}
