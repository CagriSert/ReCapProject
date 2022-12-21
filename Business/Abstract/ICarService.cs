using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null);
        List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null);
        Car GetById(Expression<Func<Car, bool>> filter);
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
