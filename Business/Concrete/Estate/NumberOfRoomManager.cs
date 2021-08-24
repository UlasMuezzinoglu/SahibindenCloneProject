using Business.Abstract.Estate;
using Business.Constraints;
using Core.Utilities.Results;
using DataAccess.Abstact.Estate;
using Entities.Concrete.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Estate
{
    public class NumberOfRoomManager : INumberOfRoomService
    {
        INumberOfRoomDal _numberOfRoomDal;

        public NumberOfRoomManager(INumberOfRoomDal numberOfRoomDal)
        {
            _numberOfRoomDal = numberOfRoomDal;
        }

        public IDataResult<List<NumberOfRoom>> GetAll()
        {
            return new SuccessDataResult<List<NumberOfRoom>>(_numberOfRoomDal.GetAll(), Messages.NumberOfRoomsListed);
        }
    }
}
