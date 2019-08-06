using FluentApi.Domain.Models;
using FluentApi.Models;

namespace FluentApi.Mappers
{
    public static class DeviceModelToDomainMapper
    {
        public static DomainDevice ToDomain(this DeviceModel @this)
        {
            return new DomainDevice()
            {
                Name = @this.Name,
                UserId = @this.UserId
            };
        }
    }
}