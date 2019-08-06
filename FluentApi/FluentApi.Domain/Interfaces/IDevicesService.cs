using FluentApi.Domain.Models;
using System.Collections.Generic;

namespace FluentApi.Domain.Interfaces
{
    public interface IDevicesService
    {
        IEnumerable<DomainDevice> SearchAllDevices();

        DomainDevice SearchDevice(int deviceId);

        void CreateDevice(DomainDevice device);

        void DeleteDevice(int deviceId);
    }
}
