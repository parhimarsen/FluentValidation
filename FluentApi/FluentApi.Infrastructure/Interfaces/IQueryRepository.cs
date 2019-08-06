using FluentApi.Infrastructure.Models;

namespace FluentApi.Infrastructure.Interfaces
{
    public interface IQueryRepository
    {
        void AddQuery(InfrastructureQuery query);
    }
}
