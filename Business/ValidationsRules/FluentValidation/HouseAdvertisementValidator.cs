using Entities.Concrete.Estate.Home;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationsRules.FluentValidation
{
    public class HouseAdvertisementValidator : AbstractValidator<HouseAdvertisement>
    {
        public HouseAdvertisementValidator()
        {

        }
    }
}
