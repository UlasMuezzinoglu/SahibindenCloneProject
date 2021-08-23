using Business.Abstract;
using Business.Constraints;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseTypeManager : IHouseTypeService
    {
        IHouseTypeDal _houseTypeDal;

        public HouseTypeManager(IHouseTypeDal houseTypeDal)
        {
            _houseTypeDal = houseTypeDal;
        }

        public IResult Add(HouseType houseType)
        {
            _houseTypeDal.Add(houseType);
            return new SuccessResult(Messages.HouseTypeAdded);
        }

        public IResult Delete(HouseType houseType)
        {
            try
            {
                _houseTypeDal.Delete(houseType);
                return new SuccessResult(Messages.HouseTypeDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseTypeCantDeledet);
            }
        }

        public IDataResult<List<HouseType>> GetAll()
        {
            return new SuccessDataResult<List<HouseType>>(_houseTypeDal.GetAll(),Messages.HouseTypesListed);
        }

        public IResult Update(HouseType houseType)
        {
            try
            {
                _houseTypeDal.Update(houseType);
                return new SuccessResult(Messages.HouseTypeUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseTypeCantUpdated);
            }
        }
    }
}
