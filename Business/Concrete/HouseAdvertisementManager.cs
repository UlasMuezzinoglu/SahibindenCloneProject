using Business.Abstract;
using Business.Constraints;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete.Estate.Home;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseAdvertisementManager : IHouseAdvertisementService
    {
        IHouseAdvertisementDal _houseAdvertisementDal;

        public HouseAdvertisementManager(IHouseAdvertisementDal houseAdvertisementDal)
        {
            _houseAdvertisementDal = houseAdvertisementDal;
        }

        [CacheRemoveAspect("IHouseAdvertisementService.Get")]
        public IResult Add(HouseAdvertisement houseAdvertisement)
        {
            houseAdvertisement.CreatedTime = DateTime.Now;
            _houseAdvertisementDal.Add(houseAdvertisement);
            return new SuccessResult(Messages.HouseAdvertisementAdded);
        }

        public IResult Delete(HouseAdvertisement houseAdvertisement)
        {
            try
            {
                _houseAdvertisementDal.Delete(houseAdvertisement);
                return new SuccessResult(Messages.HouseAdvertisementDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseAdvertisementCantDeledet);
            }
        }

        public IDataResult<List<HouseAdvertisement>> GetAll()
        {
            return new SuccessDataResult<List<HouseAdvertisement>>(_houseAdvertisementDal.GetAll(), Messages.HouseAdvertisementsListed);
        }

        public IDataResult<HouseAdvertisement> GetById(int id)
        {
            return new SuccessDataResult<HouseAdvertisement>(_houseAdvertisementDal.Get(c => c.Id == id), Messages.HouseAdvertisementListed);
        }

        public IDataResult<HouseAdvertisement> GetByUserId(int userId)
        {
            return new SuccessDataResult<HouseAdvertisement>(_houseAdvertisementDal.Get(c => c.UserId == userId), Messages.HouseAdvertisementListed);
        }

        public IDataResult<List<HouseAdvertisementDetailDto>> GetHouseAdvertisementDetailDto()
        {
            return new SuccessDataResult<List<HouseAdvertisementDetailDto>>(_houseAdvertisementDal.GetHouseAdvertisementDetails(), Messages.HouseAdvertisementsListed);
        }

        public IResult Update(HouseAdvertisement houseAdvertisement)
        {
            try
            {
                _houseAdvertisementDal.Update(houseAdvertisement);
                return new SuccessResult(Messages.HouseAdvertisementUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseAdvertisementCantUpdated);
            }
        }
    }
}
