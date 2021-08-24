using Core.Utilities.Results;
using Entities.Concrete.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Estate
{
    public interface INumberOfRoomService
    {
        IDataResult<List<NumberOfRoom>> GetAll();
    }
}
