using FluentApi.Domain.Interfaces;
using FluentApi.Infrastructure.Interfaces;

namespace FluentApi.DomainServices.Services
{
    public class DomainInitializationService : IDomainInitializationService
    {
        private readonly IMyContextInitializationService _myContextInitializationService;

        public DomainInitializationService(IMyContextInitializationService myContextInitializationService)
        {
            _myContextInitializationService = myContextInitializationService;
        }

        public void Initialize()
        {
            _myContextInitializationService.Initialize();
        }
    }
}
