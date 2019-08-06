using FluentApi.Domain.Interfaces;
using FluentApi.Domain.Models;
using FluentApi.Models;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using FluentApi.Mappers;
using IExceptionLogger = FluentApi.Interfaces.IExceptionLogger;

namespace FluentApi.Services
{
    public class ExceptionLogger : IExceptionLogger
    {
        private IQueriesService _queriesService;

        public ExceptionLogger(IQueriesService queriesService)
        {
            _queriesService = queriesService;
        }

        public void Log(HttpActionExecutedContext context)
        {
            QueryModel model = new QueryModel()
            {
                ActionDescriptor = context.Request.Method.ToString(),
                Result = context.Response.Content.ToString(),
                Url = context.Request.RequestUri.ToString()
            };
            _queriesService.AddQuery(model.ToDomain());
        }
    }
}