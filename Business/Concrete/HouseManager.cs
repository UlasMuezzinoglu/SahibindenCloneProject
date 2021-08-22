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
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }

        public IResult Add(House house)
        {
            _houseDal.Add(house);
            return new SuccessResult("Konut İlanı Eklendi");
        }

        public IResult Delete(House house)
        {
            try
            {
                _houseDal.Delete(house);
                return new SuccessResult("Konut İlanı Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Konut İlanı Silinemedi... böyle birşey artık olmayabilir");
            }
        }

        public IDataResult<List<House>> GetAll()
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(),"Konut İlanları Listelendi");
        }

        public IDataResult<House> GetById(int id)
        {
            return new SuccessDataResult<House>(_houseDal.Get(ho => ho.Id == id), "Konut İlanları Listelendi");
        }

        public IDataResult<House> GetByUserId(int userId)
        {
            return new SuccessDataResult<House>(_houseDal.Get(ho => ho.UserId == userId), "Konut İlanları Listelendi");
        }

        public IResult Update(House house)
        {
            try
            {
                _houseDal.Update(house);
                return new SuccessResult("Konut İlanı Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Konut İlanı Silinemedi... böyle birşey artık olmayabilir");
            }
        }
    }
}
