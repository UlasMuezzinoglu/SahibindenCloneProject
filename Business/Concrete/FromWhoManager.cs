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
    public class FromWhoManager : IFromWhoService
    {
        IFromWhoDal _fromWhoDal;

        public FromWhoManager(IFromWhoDal fromWhoDal)
        {
            _fromWhoDal = fromWhoDal;
        }

        public IResult Add(FromWho fromWho)
        {
            _fromWhoDal.Add(fromWho);
            return new SuccessResult("Kimden Tipi Eklendi");
        }

        public IResult Delete(FromWho fromWho)
        {
            try
            {
                _fromWhoDal.Delete(fromWho);
                return new SuccessResult("Kimden Tipi Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Kimden Tipi Silinemedi... böyle birşey artık olmayabilir");
            }
        }

        public IDataResult<List<FromWho>> GetAll()
        {
            return new SuccessDataResult<List<FromWho>>(_fromWhoDal.GetAll(),"Kimden Tipi Listelendi");
        }

        public IResult Update(FromWho fromWho)
        {
            try
            {
                _fromWhoDal.Update(fromWho);
                return new SuccessResult("Kimden Tipi Güncellendi");
            }
            catch (Exception)
            {

                return new ErrorResult("Kimden Tipi Güncellenemedi... böyle birşey artık olmayabilir");
            }
        }
    }
}
