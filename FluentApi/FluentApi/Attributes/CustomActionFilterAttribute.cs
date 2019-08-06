using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using FluentApi.Domain.Interfaces;
using FluentApi.Interfaces;

namespace FluentApi.Attributes
{
    public class CustomActionFilterAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        private readonly IRequestLogger _requestLogger;

        public CustomActionFilterAttribute(IRequestLogger requestLogger)
        {
            _requestLogger = requestLogger;
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionContext)
        {
            _requestLogger.Log(actionContext);
        }
    }
}