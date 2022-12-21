using Business.Abstract;
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

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll(Expression<Func<Brand,bool>> filter = null)
        {
            return _brandDal.GetAll(filter);
        }

        public Brand GetById(Expression<Func<Brand, bool>> filter)
        {
            return _brandDal.Get(filter);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
