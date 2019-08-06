using System.Web.Http.Filters;
using FluentApi.Domain.Interfaces;
using FluentApi.Interfaces;

namespace FluentApi.Attributes
{
    public class ExceptionFilterAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        private readonly IExceptionLogger _exceptionLogger;

        public ExceptionFilterAttribute(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            _exceptionLogger.Log(actionExecutedContext);
        }
    }
}