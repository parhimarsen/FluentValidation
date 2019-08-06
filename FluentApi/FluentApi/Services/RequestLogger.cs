using System.Web.Http.Filters;
using FluentApi.Domain.Interfaces;
using FluentApi.Interfaces;
using FluentApi.Mappers;
using FluentApi.Models;

namespace FluentApi.Services
{
    public class RequestLogger : IRequestLogger
    {
        private IQueriesService _queriesService;

        public RequestLogger(IQueriesService queriesService)
        {
            _queriesService = queriesService;
        }

        public void Log(HttpActionExecutedContext context)
        {
            QueryModel model = new QueryModel()
            {
                ActionDescriptor = context.Request.Method.ToString(),
                Result = context.Exception.Message,
                Url = context.Request.RequestUri.ToString()
            };
            _queriesService.AddQuery(model.ToDomain());
        }
    }
}