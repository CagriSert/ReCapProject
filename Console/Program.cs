﻿using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService(new EfCarDal());
            foreach (var item in carService.GetCarsDetail())
            {
                System.Console.WriteLine(item.Id + " " + item.ModelYear + " " + item.Description +" "+ item.ColorName + " "+ item.BrandName );
            }
            //carService.Add(new Car { ModelYear = 2001, Description = "Test Verisidir", DailyPrice = 150, ColorId = 1, BrandId = 2 });
            
            //CarService carService = new CarService(new InMemoryCarDal());
            //foreach (var item in carService.GetAll())
            //{
            //    System.Console.WriteLine(item.Description);
            //} 
        }
    }
}
