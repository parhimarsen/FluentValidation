using FluentApi.Domain.Models;
using FluentApi.Models;

namespace FluentApi.Mappers
{
    public static class DomainToUserModelMapper
    {
        public static UserModel ToModel(this DomainUser @this)
        {
            return new UserModel()
            {
                Name = @this.Name,
                Role = @this.Role,
                Sex = @this.Sex,
                Age = @this.Age
            };
        }
    }
}