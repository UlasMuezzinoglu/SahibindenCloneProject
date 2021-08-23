using Business.Abstract;
using Business.Constraints;
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
            return new SuccessResult(Messages.DeedTypeAdded);
        }

        public IResult Delete(DeedType deedType)
        {
            try
            {
                _deedTypeDal.Delete(deedType);
                return new SuccessResult(Messages.DeedTypeDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.DeedTypeCantDeledet);
            }
        }

        public IDataResult<List<DeedType>> GetAll()
        {
            return new SuccessDataResult<List<DeedType>>(_deedTypeDal.GetAll(), Messages.DeedTypesListed);

        }

        public IResult Update(DeedType deedType)
        {
            try
            {
                _deedTypeDal.Update(deedType);
                return new SuccessResult(Messages.DeedTypeUpdated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.DeedTypeCantUpdated);
            }
        }
    }
}
