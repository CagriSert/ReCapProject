using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ColorService : IColorService
    {
        IColorDal _colorDal;

        public ColorService(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            var data = _colorDal.GetAll(filter);
            return new SuccessDataResult<List<Color>>(data, Messages.Listed);
        }

        public IDataResult<Color> GetById(Expression<Func<Color, bool>> filter)
        {
            var data = _colorDal.Get(filter);
            return new SuccessDataResult<Color>(data, Messages.Listed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.Updated);
        }
    }
}
