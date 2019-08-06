using FluentApi.Domain.Models;

namespace FluentApi.Domain.Interfaces
{
    public interface IQueriesService
    {
        void AddQuery(DomainQuery context);
    }
}
