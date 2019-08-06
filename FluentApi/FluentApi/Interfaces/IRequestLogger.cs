using System.Web.Http.Filters;

namespace FluentApi.Interfaces
{
    public interface IRequestLogger
    {
        void Log(HttpActionExecutedContext context);
    }
}
