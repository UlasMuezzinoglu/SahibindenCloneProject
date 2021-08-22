using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IFromWhoService
    {
        IDataResult<List<FromWho>> GetAll();

        IResult Add(FromWho fromWho);
        IResult Delete(FromWho fromWho);
        IResult Update(FromWho fromWho);

    }
}
