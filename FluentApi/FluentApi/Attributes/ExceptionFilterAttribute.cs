using FluentApi.Domain.Interfaces;
using FluentApi.Mappers;
using FluentApi.Models;
using System.Net.Http;
using System.Web.Http.Filters;

namespace FluentApi.Attributes
{
    public class ExceptionFilterAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var logService =
                (IQueriesService)actionExecutedContext.Request.GetDependencyScope().GetService(typeof(IQueriesService));

            QueryModel model = new QueryModel()
            {
                ActionDescriptor = actionExecutedContext.Request.Method.ToString(),
                Result = actionExecutedContext.Exception.Message,
                Url = actionExecutedContext.Request.RequestUri.ToString()
            };

            logService.AddQuery(model.ToDomain());
        }
    }
}