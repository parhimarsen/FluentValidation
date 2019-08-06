using System.Web.Http.Filters;

namespace FluentApi.Interfaces
{
    public interface IExceptionLogger
    {
        void Log(HttpActionExecutedContext context);
    }
}
