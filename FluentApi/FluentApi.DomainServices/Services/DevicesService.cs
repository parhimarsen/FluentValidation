using FluentApi.Domain.Interfaces;
using FluentApi.Domain.Models;
using FluentApi.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using FluentApi.DomainServices.Mappers;

namespace FluentApi.DomainServices.Services
{
    public class DevicesService : IDevicesService
    {
        private readonly IDevicesRepository _devicesRepository;

        public DevicesService(IDevicesRepository devicesRepository)
        {
            _devicesRepository = devicesRepository;
        }

        public IEnumerable<DomainDevice> SearchAllDevices()
        {
            var devices = _devicesRepository.GetAllDevices();

            return devices.Select(_ => _?.ToDomain());
        }

        public DomainDevice SearchDevice(int deviceId)
        {
            return _devicesRepository.GetDevice(deviceId)?.ToDomain();
        }

        public void CreateDevice(DomainDevice device)
        {
            _devicesRepository.CreateDevice(device?.ToInfrastructure());
        }

        public void DeleteDevice(int deviceId)
        {
            _devicesRepository.DeleteDevice(deviceId);
        }
    }
}
