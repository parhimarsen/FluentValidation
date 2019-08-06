using FluentApi.Models;
using FluentValidation;

namespace FluentApi.Validators
{
    public class DeviceModelValidator : AbstractValidator<DeviceModel>
    {
        public DeviceModelValidator()
        {
            When(_ => _ != null, () =>
            {
                RuleFor(_ => _.Name).NotEmpty();
                RuleFor(_ => _.UserId).NotEmpty();
            });
        }
    }
}