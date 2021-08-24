using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constraints;
using Core.Aspects.Autofac.Caching;
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

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IHeatingTypeService.Get")]
        public IResult Add(HeatingType heatingType)
        {
            _heatingTypeDal.Add(heatingType);
            return new SuccessResult(Messages.HeatingTypeAdded);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IHeatingTypeService.Get")]
        public IResult Delete(HeatingType heatingType)
        {
            try
            {
                _heatingTypeDal.Delete(heatingType);
                return new SuccessResult(Messages.HeatingTypeDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HeatingTypeCantDeledet);
            }
        }

        [CacheAspect]
        public IDataResult<List<HeatingType>> GetAll()
        {
            return new SuccessDataResult<List<HeatingType>>(_heatingTypeDal.GetAll(), Messages.HeatingTypesListed);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IHeatingTypeService.Get")]
        public IResult Update(HeatingType heatingType)
        {
            try
            {
                _heatingTypeDal.Update(heatingType);
                return new SuccessResult(Messages.HeatingTypeUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HeatingTypeCantUpdated);
            }
        }
    }
}
