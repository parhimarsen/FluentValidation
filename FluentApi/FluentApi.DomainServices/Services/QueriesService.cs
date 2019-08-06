using FluentApi.Domain.Interfaces;
using FluentApi.Domain.Models;
using FluentApi.DomainServices.Mappers;
using FluentApi.Infrastructure.Interfaces;

namespace FluentApi.DomainServices.Services
{
    public class QueriesService : IQueriesService
    {
        private readonly IQueryRepository _queryRepository;

        public QueriesService(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public void AddQuery(DomainQuery query)
        {
            _queryRepository.AddQuery(query?.ToInfrastructure());
        }
    }
}
