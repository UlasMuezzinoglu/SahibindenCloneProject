using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constraints;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HomeTypeManager : IHomeTypeService
    {
        IHomeTypeDal _homeTypeDal;

        public HomeTypeManager(IHomeTypeDal homeTypeDal)
        {
            _homeTypeDal = homeTypeDal;
        }

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IHomeTypeService.Get")]
        public IResult Add(HomeType homeType)
        {
            _homeTypeDal.Add(homeType);
            return new SuccessResult(Messages.HomeTypeAdded);
        }

        [CacheAspect]
        public IDataResult<List<HomeType>> GetAll()
        {
            return new SuccessDataResult<List<HomeType>>(_homeTypeDal.GetAll(), Messages.HomeTypesListed);
        }
    }
}
