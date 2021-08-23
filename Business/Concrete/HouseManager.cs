using Business.Abstract;
using Business.Constraints;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }

        public IResult Add(House house)
        {
            house.CreatedTime = DateTime.Now;
            _houseDal.Add(house);
            return new SuccessResult(Messages.HouseAdded);
        }

        public IResult Delete(House house)
        {
            try
            {
                _houseDal.Delete(house);
                return new SuccessResult(Messages.HouseDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseCantDeledet);
            }
        }

        public IDataResult<List<House>> GetAll()
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(),Messages.HousesListed);
        }

        public IDataResult<House> GetById(int id)
        {
            return new SuccessDataResult<House>(_houseDal.Get(ho => ho.Id == id), Messages.HousesListedById);
        }

        public IDataResult<House> GetByUserId(int userId)
        {
            return new SuccessDataResult<House>(_houseDal.Get(ho => ho.UserId == userId), Messages.HousesListedByUserId);
        }

        public IDataResult<List<HouseAdvertisementDetailDto>> GetHouseAdvertisementDetailDto()
        {
            return new SuccessDataResult<List<HouseAdvertisementDetailDto>>(_houseDal.GetHouseAdvertisementDetails(), Messages.HouseAdvertisementListedDetailDto);
        }

        public IResult Update(House house)
        {
            try
            {
                _houseDal.Update(house);
                return new SuccessResult(Messages.HouseUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.HouseCantUpdated);
            }
        }
    }
}
