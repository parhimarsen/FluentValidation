using FluentApi.Infrastructure.Interfaces;
using FluentApi.Infrastructure.Models;
using FluentApi.InfrastructureServices.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace FluentApi.InfrastructureServices.Repositories
{
    public class DevicesRepository : IDevicesRepository
    {
        private readonly MyContext _context;

        public DevicesRepository(MyContext context)
        {
            _context = context;
        }

        public IEnumerable<InfrastructureDevice> GetAllDevices()
        {
            return _context.Devices.ToList();
        }

        public InfrastructureDevice GetDevice(int deviceId)
        {
            return _context.Devices.FirstOrDefault(_ => _.Id == deviceId);
        }

        public void CreateDevice(InfrastructureDevice device)
        {
            device.Id = _context.Devices.Count() + 1;
            _context.Devices.Add(device);
        }

        public void DeleteDevice(int deviceId)
        {
            InfrastructureDevice device = GetDevice(deviceId);
            if (device != null)
            {
                _context.Remove(device);
            }
        }
    }
}
