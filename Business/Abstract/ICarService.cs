using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCarsByColorId(Expression<Func<Car, bool>> filter = null);
        IDataResult<List<Car>> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null);
        IDataResult<List<CarDetailDto>> GetCarsDetail(Expression<Func<CarDetailDto, bool>> filter = null);
        IDataResult<Car> GetById(Expression<Func<Car, bool>> filter);
        IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
