using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concreate
{
    public class CarService : ICarService
    {
        ICarDal _carDal;

        public CarService(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
                _carDal.Add(car);
            else
                throw new Exception("Hata Zorunluluklara Uymuyor");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            return _carDal.Get(filter);
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
