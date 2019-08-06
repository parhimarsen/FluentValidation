using FluentApi.Domain.Models;
using FluentApi.Infrastructure.Models;

namespace FluentApi.DomainServices.Mappers
{
    public static class DomainToInfrastructureDeviceMapper
    {
        public static InfrastructureDevice ToInfrastructure(this DomainDevice @this)
        {
            return new InfrastructureDevice()
            {
                Name = @this.Name,
                UserId = @this.UserId
            };
        }
    }
}
