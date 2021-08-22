using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationsRules.FluentValidation
{
    public class DeedTypeValidator : AbstractValidator<DeedType>
    {
        public DeedTypeValidator()
        {
            RuleFor(type => type.DeedTypeName).NotEmpty();
            RuleFor(type => type.DeedTypeName).MinimumLength(2);
        }
    }
}
