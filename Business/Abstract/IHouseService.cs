using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll();
        IDataResult<House> GetById(int id);
        IDataResult<House> GetByUserId(int userId);

        IResult Add(House house);
        IResult Delete(House house);
        IResult Update(House house);

        IDataResult<List<HouseAdvertisementDetailDto>> GetHouseAdvertisementDetailDto();


    }
}
