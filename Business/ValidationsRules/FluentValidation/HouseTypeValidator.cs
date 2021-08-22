using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationsRules.FluentValidation
{
    public class HouseTypeValidator : AbstractValidator<HouseType>
    {
        public HouseTypeValidator()
        {
            RuleFor(type => type.HouseTypeName).NotEmpty();
            RuleFor(type => type.HouseTypeName).MinimumLength(2);
        }
    }
}
