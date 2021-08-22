using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.concrete
{
    public class DeedTypeManager : IDeedTypeService
    {

        IDeedTypeDal _deedTypeDal;

        public DeedTypeManager(IDeedTypeDal deedTypeDal)
        {
            _deedTypeDal = deedTypeDal;
        }

        public IResult Add(DeedType deedType)
        {
            _deedTypeDal.Add(deedType);
            return new SuccessResult("Tapu Tipi Eklendi");
        }

        public IResult Delete(DeedType deedType)
        {
            try
            {
                _deedTypeDal.Delete(deedType);
                return new SuccessResult("Tapu Tipi Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Tapu Tipi Silinemedi");
            }
        }

        public IDataResult<List<DeedType>> GetAll()
        {
            return new SuccessDataResult<List<DeedType>>(_deedTypeDal.GetAll(), "Tapu Tipleri Listelendi");

        }

        public IResult Update(DeedType deedType)
        {
            try
            {
                _deedTypeDal.Update(deedType);
                return new SuccessResult("Tapu Tipi Eklendi");
            }
            catch (Exception)
            {
                return new ErrorResult("Tapu Tipi Güncellenemedi... Böyle Birşey Olmayabilir");
            }
        }
    }
}
