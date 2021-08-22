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
    public class HeatingTypeManager : IHeatingTypeService
    {
        IHeatingTypeDal _heatingTypeDal;

        public HeatingTypeManager(IHeatingTypeDal heatingTypeDal)
        {
            _heatingTypeDal = heatingTypeDal;
        }

        public IResult Add(HeatingType heatingType)
        {
            _heatingTypeDal.Add(heatingType);
            return new SuccessResult("Isıtma Tipi Eklendi");
        }

        public IResult Delete(HeatingType heatingType)
        {
            try
            {
                _heatingTypeDal.Delete(heatingType);
                return new SuccessResult("Isıtma Tipi Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Isıtma Tipi Silinemedi... böyle birşey artık olmayabilir");
            }
        }

        public IDataResult<List<HeatingType>> GetAll()
        {
            return new SuccessDataResult<List<HeatingType>>(_heatingTypeDal.GetAll(), "Isıtma Tipi Listelendi");
        }

        public IResult Update(HeatingType heatingType)
        {
            try
            {
                _heatingTypeDal.Update(heatingType);
                return new SuccessResult("Isıtma Tipi Güncellendi");
            }
            catch (Exception)
            {

                return new ErrorResult("Isıtma Tipi Güncellenemedi... böyle birşey artık olmayabilir");
            }
        }
    }
}
