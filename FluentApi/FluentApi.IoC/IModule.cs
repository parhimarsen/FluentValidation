using Microsoft.Practices.Unity;

namespace FluentApi.IoC
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
