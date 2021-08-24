using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Estate
{
    public class BuildingAge :IEntity
    {
        public int Id { get; set; }
        public string BuildingAgeName { get; set; }
    }
}
