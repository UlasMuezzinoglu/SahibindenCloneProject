using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDeedTypeDal : EfEntityRepositoryBase<DeedType, SahibindenCloneContext>, IDeedTypeDal
    {

    }
}
