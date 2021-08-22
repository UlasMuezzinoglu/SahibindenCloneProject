using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationsRules.FluentValidation
{
    public class HeatingTypeValidator : AbstractValidator<HeatingType>
    {
        public HeatingTypeValidator()
        {
            RuleFor(type => type.HeatingTypeName).NotEmpty();
            RuleFor(type => type.HeatingTypeName).MinimumLength(2);
        }
    }
}
