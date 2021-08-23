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
            return new SuccessResult(Messages.HeatingTypeAdded);
        }

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

        public IDataResult<List<HeatingType>> GetAll()
        {
            return new SuccessDataResult<List<HeatingType>>(_heatingTypeDal.GetAll(), Messages.HeatingTypesListed);
        }

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
