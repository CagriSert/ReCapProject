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
    public class UserService : IUserService
    {
        IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            var data = _userDal.GetAll(filter);
            return new SuccessDataResult<List<User>>(data, Messages.Listed);
        }

        public IDataResult<User> GetById(Expression<Func<User, bool>> filter)
        {
            var data = _userDal.Get(filter);
            return new SuccessDataResult<User>(data, Messages.Get);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
    }
}
