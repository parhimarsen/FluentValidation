using FluentApi.Domain.Models;
using FluentApi.Infrastructure.Models;

namespace FluentApi.DomainServices.Mappers
{
    public static class InfrastructureToDomainUserMapper
    {
        public static DomainUser ToDomain(this InfrastructureUser @this)
        {
            return new DomainUser()
            {
                Name = @this.Name,
                Role = @this.Role,
                Sex = @this.Sex,
                Age = @this.Age
            };
        }
    }
}
