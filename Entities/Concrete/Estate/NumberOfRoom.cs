using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Estate
{
    public class NumberOfRoom :IEntity
    {
        public int Id { get; set; }
        public string NumberOfRoomName { get; set; }
    }
}
