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
    public class BuildingAgeManager : IBuildingAgeService
    {
        IBuildingAgeDal _buildingAgeDal;

        public BuildingAgeManager(IBuildingAgeDal buildingAgeDal)
        {
            _buildingAgeDal = buildingAgeDal;
        }

        public IDataResult<List<BuildingAge>> GetAll()
        {
            return new SuccessDataResult<List<BuildingAge>>(_buildingAgeDal.GetAll(),Messages.BuildingAgesListed);
        }
    }
}
