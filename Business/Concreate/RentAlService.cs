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
    public class RentAlService : IRentalService
    {
        IRentalDal _rentalDal;

        public RentAlService(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var data = _rentalDal.Get(x => x.CarId == rental.CarId);
            if (data != null && data.ReturnDate != null)
            {
                return new ErrorResult(Messages.ReturnDateError);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Rental>> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            var data = _rentalDal.GetAll(filter);
            return new SuccessDataResult<List<Rental>>(data, Messages.Listed);
        }

        public IDataResult<Rental> GetById(Expression<Func<Rental, bool>> filter)
        {
            var data = _rentalDal.Get(filter);
            return new SuccessDataResult<Rental>(data, Messages.Get);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
