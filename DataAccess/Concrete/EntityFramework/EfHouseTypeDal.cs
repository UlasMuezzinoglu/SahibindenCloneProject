using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseTypeDal : EfEntityRepositoryBase<HouseType, SahibindenCloneContext>, IHouseTypeDal
    {

    }
}
