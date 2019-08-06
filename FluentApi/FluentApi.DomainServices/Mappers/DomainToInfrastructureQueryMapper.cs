using FluentApi.Domain.Models;
using FluentApi.Infrastructure.Models;

namespace FluentApi.DomainServices.Mappers
{
    public static class DomainToInfrastructureQueryMapper
    {
        public static InfrastructureQuery ToInfrastructure(this DomainQuery @this)
        {
            return new InfrastructureQuery()
            {
                Url = @this.Url,
                ActionDescriptor = @this.ActionDescriptor,
                Result = @this.Result
            };
        }
    }
}
