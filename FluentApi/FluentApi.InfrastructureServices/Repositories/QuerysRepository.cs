using FluentApi.Infrastructure.Interfaces;
using FluentApi.Infrastructure.Models;
using FluentApi.InfrastructureServices.Contexts;
using System.Linq;

namespace FluentApi.InfrastructureServices.Repositories
{
    public class QuerysRepository : IQueryRepository
    {
        private readonly MyContext _context;

        public QuerysRepository(MyContext context)
        {
            _context = context;
        }

        public void AddQuery(InfrastructureQuery query)
        {
            query.Id = _context.Queries.Count() + 1;
            _context.Queries.Add(query);
        }
    }
}
