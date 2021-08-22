using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationsRules.FluentValidation
{
    public class FromWhoValidator : AbstractValidator<FromWho>
    {
        public FromWhoValidator()
        {
            RuleFor(type => type.FromWhoName).NotEmpty();
            RuleFor(type => type.FromWhoName).MinimumLength(2);
        }
    }
}
