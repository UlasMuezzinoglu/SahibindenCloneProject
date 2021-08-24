using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHeatingTypeService
    {
        IDataResult<List<HeatingType>> GetAll();

        IResult Add(HeatingType heatingType);
        IResult Delete(HeatingType heatingType);
        IResult Update(HeatingType heatingType);

    }
}
