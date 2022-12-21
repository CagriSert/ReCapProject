using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        Color GetById(Expression<Func<Color, bool>> filter);
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
    }
}
