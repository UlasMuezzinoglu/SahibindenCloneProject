using Core.Utilities.Results;
using Entities.Concrete.Estate.Home;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHouseAdvertisementService
    {
        IDataResult<List<HouseAdvertisement>> GetAll();
        IDataResult<HouseAdvertisement> GetById(int id);
        IDataResult<HouseAdvertisement> GetByUserId(int userId);

        IResult Add(HouseAdvertisement houseAdvertisement);
        IResult Delete(HouseAdvertisement houseAdvertisement);
        IResult Update(HouseAdvertisement houseAdvertisement);
        IResult UpdateStatus(int id, bool status);

        IDataResult<List<HouseAdvertisementDetailDto>> GetHouseAdvertisementDetailDto();


    }
}
