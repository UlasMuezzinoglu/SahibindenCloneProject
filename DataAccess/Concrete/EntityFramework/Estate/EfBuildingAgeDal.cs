using Core.DataAccess.EntityFramework;
using DataAccess.Abstact.Estate;
using Entities.Concrete.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Estate
{
    public class EfBuildingAgeDal : EfEntityRepositoryBase<BuildingAge, SahibindenCloneContext>, IBuildingAgeDal
    {

    }
}
