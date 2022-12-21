using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.InMemory;
using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService(new InMemoryCarDal());
            //foreach (var item in carService.GetAll())
            //{
            //    System.Console.WriteLine(item.Description);
            //} 
        }
    }
}
