using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using FluentApi.Attributes;
using FluentApi.Domain.Interfaces;
using FluentApi.Mappers;
using FluentApi.Models;

namespace FluentApi.Controllers
{
    [RoutePrefix("api/devices")]
    [CustomActionFilter, ExceptionFilter]
    public class DevicesController : ApiController
    {
        private IDevicesService _devicesService;

        public DevicesController(IDevicesService devicesService)
        {
            _devicesService = devicesService;
        }

        [HttpGet, Route("")]
        public IEnumerable<DeviceModel> GetAllDevices()
        {
            return _devicesService.SearchAllDevices().Select(_ => _?.ToModel());
        }

        [HttpGet, Route("{deviceId:int}")]
        public DeviceModel GetDevice(int deviceId)
        {
            return _devicesService.SearchDevice(deviceId)?.ToModel();
        }

        [ExceptionFilter]
        [HttpPost, Route("")]
        public void PostDevice([FromBody] DeviceModel device)
        {
            _devicesService.CreateDevice(device?.ToDomain());
        }

        [HttpDelete, Route("")]
        public void DeleteDevice(int deviceId)
        {
            _devicesService.DeleteDevice(deviceId);
        }

    }
}
