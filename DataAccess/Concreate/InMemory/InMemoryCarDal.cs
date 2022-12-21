using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){Id=1,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy",ModelYear=2001},
                new Car(){Id=2,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy1",ModelYear=2002},
                new Car(){Id=3,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy2",ModelYear=2003},
                new Car(){Id=4,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy3",ModelYear=2004},
                new Car(){Id=5,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy4",ModelYear=2005},
                new Car(){Id=6,BrandId=2,ColorId=1,DailyPrice=112,Description="Testy5",ModelYear=2006}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            _cars.Remove(_cars.Where(x => x.Id == id).FirstOrDefault());
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.Where(x => x.Id == car.Id).FirstOrDefault();
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.Description = car.Description;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.ColorId = car.ColorId;
            updatedCar.BrandId = car.BrandId;
        }
    }
}
