using Business.Abstract;
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
            return new SuccessResult("Ev Tipi Eklendi");
        }

        public IResult Delete(HouseType houseType)
        {
            try
            {
                _houseTypeDal.Delete(houseType);
                return new SuccessResult("Ev Tipi Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Ev Tipi Silinemedi... böyle birşey artık olmayabilir");
            }
        }

        public IDataResult<List<HouseType>> GetAll()
        {
            return new SuccessDataResult<List<HouseType>>(_houseTypeDal.GetAll(),"Ev Tipleri Listelendi");
        }

        public IResult Update(HouseType houseType)
        {
            try
            {
                _houseTypeDal.Update(houseType);
                return new SuccessResult("Ev Tipi Güncellendi");
            }
            catch (Exception)
            {

                return new ErrorResult("Ev Tipi Güncellenemedi... böyle birşey artık olmayabilir");
            }
        }
    }
}
