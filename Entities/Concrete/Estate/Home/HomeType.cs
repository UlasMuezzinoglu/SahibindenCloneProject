using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Estate
{
    public class HomeType :IEntity             // daire mi rezidans mı prefabrik mi falan
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
