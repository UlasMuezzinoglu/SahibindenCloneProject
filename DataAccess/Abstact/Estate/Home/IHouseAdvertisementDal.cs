using Core.DataAccess;
using Entities.Concrete.Estate.Home;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstact
{
    public interface IHouseAdvertisementDal : IEntityRepository<HouseAdvertisement>
    {
        List<HouseAdvertisementDetailDto> GetHouseAdvertisementDetails();

    }
}
