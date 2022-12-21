﻿using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        Brand GetById(Expression<Func<Brand, bool>> filter);
        List<Brand> GetAll(Expression<Func<Brand,bool>> filter = null);
    }
}
