using FluentApi.Domain.Interfaces;
using FluentApi.Mappers;
using FluentApi.Models;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace FluentApi.Attributes
{
    public class CustomActionFilterAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        QueryModel model = new QueryModel();
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            model.ActionDescriptor = actionContext.Request.Method.ToString();
            model.Url = actionContext.Request.RequestUri.ToString();
            //Controller = actionContext.ControllerContext.ControllerDescription.ControllerName
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionContext)
        {
            var logService =
                (IQueriesService)actionContext.Request.GetDependencyScope().GetService(typeof(IQueriesService));
            model.Result = actionContext.Response.Content.ToString();
            logService.AddQuery(model.ToDomain());
        }
    }
}