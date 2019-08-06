using FluentApi.Domain.Models;
using FluentApi.Models;

namespace FluentApi.Mappers
{
    public static class DomainToDeviceModelMapper
    {
        public static DeviceModel ToModel(this DomainDevice @this)
        {
            return new DeviceModel()
            {
                Name = @this.Name,
                UserId = @this.UserId
            };
        }
    }
}