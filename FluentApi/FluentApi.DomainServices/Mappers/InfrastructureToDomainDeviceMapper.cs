using FluentApi.Domain.Models;
using FluentApi.Infrastructure.Models;

namespace FluentApi.DomainServices.Mappers
{
    public static class InfrastructureToDomainDeviceMapper
    {
        public static DomainDevice ToDomain(this InfrastructureDevice @this)
        {
            return new DomainDevice()
            {
                Name = @this.Name,
                UserId = @this.UserId
            };
        }
    }
}
