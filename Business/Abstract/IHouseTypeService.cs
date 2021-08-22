using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHouseTypeService
    {
        IDataResult<List<HouseType>> GetAll();

        IResult Add(HouseType houseType);
        IResult Delete(HouseType houseType);
        IResult Update(HouseType houseType);

    }
}
