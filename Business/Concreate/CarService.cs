using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
            }
            else
                return new ErrorResult(Messages.ErrorAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            var data = _carDal.GetAll(filter);
            return new SuccessDataResult<List<Car>>(data, Messages.Listed);
        }

        public IDataResult<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            var data = _carDal.Get(filter);
            return new SuccessDataResult<Car>(data, Messages.Listed);

        }

        public IDataResult<List<Car>> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            var data = _carDal.GetAll(filter);
            return new SuccessDataResult<List<Car>>(data, Messages.Listed);

        }

        public IDataResult<List<Car>> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            var data = _carDal.GetAll(filter);
            return new SuccessDataResult<List<Car>>(data, Messages.Listed);

        }

        public IDataResult<List<CarDetailDto>> GetCarsDetail(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            var data = _carDal.GetCarDetails(filter);
            return new SuccessDataResult<List<CarDetailDto>>(data, Messages.Listed);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}
