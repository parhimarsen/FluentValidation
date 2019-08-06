using FluentApi.Domain.Models;
using FluentApi.Models;

namespace FluentApi.Mappers
{
    public static class QueryModelToDomainMapper
    {
        public static DomainQuery ToDomain(this QueryModel @this)
        {
            return new DomainQuery()
            {
                ActionDescriptor = @this.ActionDescriptor,
                Result = @this.Result,
                Url = @this.Url
            };
        }
    }
}