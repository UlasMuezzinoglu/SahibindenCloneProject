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
    public class FromWhoManager : IFromWhoService
    {
        IFromWhoDal _fromWhoDal;

        public FromWhoManager(IFromWhoDal fromWhoDal)
        {
            _fromWhoDal = fromWhoDal;
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IFromWhoService.Get")]
        public IResult Add(FromWho fromWho)
        {
            _fromWhoDal.Add(fromWho);
            return new SuccessResult(Messages.FromWhoAdded);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IFromWhoService.Get")]
        public IResult Delete(FromWho fromWho)
        {
            try
            {
                _fromWhoDal.Delete(fromWho);
                return new SuccessResult(Messages.FromWhoDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.FromWhoCantDeledet);
            }
        }

        [CacheAspect]
        public IDataResult<List<FromWho>> GetAll()
        {
            return new SuccessDataResult<List<FromWho>>(_fromWhoDal.GetAll(),Messages.FromWhosListed);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IFromWhoService.Get")]
        public IResult Update(FromWho fromWho)
        {
            try
            {
                _fromWhoDal.Update(fromWho);
                return new SuccessResult(Messages.FromWhoUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.FromWhoCantUpdated);
            }
        }
    }
}
