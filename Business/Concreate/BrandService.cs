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
    public class BrandService : IBrandService
    {
        IBrandDal _brandDal;

        public BrandService(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            var data = _brandDal.GetAll(filter);
            return new SuccessDataResult<List<Brand>>(data, Messages.Listed);
        }

        public IDataResult<Brand> GetById(Expression<Func<Brand, bool>> filter)
        {
            var data = _brandDal.Get(filter);
            return new SuccessDataResult<Brand>(data, Messages.Get);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
