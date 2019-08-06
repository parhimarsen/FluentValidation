using FluentApi.Infrastructure.Models;
using System.Collections.Generic;

namespace FluentApi.Infrastructure.Interfaces
{
    public interface IDevicesRepository
    {
        IEnumerable<InfrastructureDevice> GetAllDevices();

        InfrastructureDevice GetDevice(int deviceId);

        void CreateDevice(InfrastructureDevice device);

        void DeleteDevice(int deviceId);
    }
}
