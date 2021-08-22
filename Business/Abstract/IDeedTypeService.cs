using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeedTypeService
    {
        IDataResult<List<DeedType>> GetAll();

        IResult Add(DeedType deedType);
        IResult Delete(DeedType deedType);
        IResult Update(DeedType deedType);

    }
}
