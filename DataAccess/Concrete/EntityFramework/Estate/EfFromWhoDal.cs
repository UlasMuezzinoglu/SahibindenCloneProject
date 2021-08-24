using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFromWhoDal : EfEntityRepositoryBase<FromWho, SahibindenCloneContext>, IFromWhoDal
    {

    }
}
