using Core.DataAccess.DataAccess;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapProjectDBContext>, IColorDal
    {

    }
}
