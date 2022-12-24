using Core.DataAccess.DataAccess;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var data = (from c in context.Cars
                            join co in context.Colors on c.ColorId equals co.Id
                            join br in context.Brands on c.BrandId equals br.Id
                            select new CarDetailDto
                            {
                                Id = c.Id,
                                BrandName = br.Name,
                                ColorName = co.Name,
                                Description = c.Description,
                                ModelYear = c.ModelYear
                            });

                return filter == null ? data.ToList() : data.Where(filter).ToList();
            }
        }
    }
}
