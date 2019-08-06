using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FluentApi.Domain.Interfaces;
using FluentApi.Mappers;
using FluentApi.Models;

namespace FluentApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet, Route("")]
        public IEnumerable<UserModel> GetAllUsers()
        {
            return _usersService.SearchAllUsers().Select(_ => _?.ToModel());
        }

        [HttpGet, Route("{userId:int}")]
        public UserModel GetUser(int userId)
        {
            return _usersService.SearchUser(userId).ToModel();
        }

        [HttpGet, Route("{userId:int}/devices")]
        public IEnumerable<DeviceModel> GetAllDevicesOfUser(int userId)
        {
            return _usersService.SearchAllDevicesOfUser(userId).Select(_ => _?.ToModel());
        }

        [HttpGet, Route("{userId:int}/devices/{deviceId}")]
        public DeviceModel GetAllDevicesOfUser(int userId, int deviceId)
        {
            return _usersService.SearchDeviceOfUser(userId, deviceId).ToModel();
        }
    }
}
