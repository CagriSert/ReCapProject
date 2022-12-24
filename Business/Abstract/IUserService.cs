using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(Expression<Func<User, bool>> filter);
        IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null);
    }
}
