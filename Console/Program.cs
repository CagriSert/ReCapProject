using Business.Abstract;
using Business.Concreate;
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

            RentAlService rentAlService = new RentAlService(new EfRentalDal());
            rentAlService.Add(new Rental { CustomerId = 1, CarId = 2, RentDate = Convert.ToDateTime("18.12.222"), ReturnDate = Convert.ToDateTime("20.12.222") });

            ////AddCar();
            //AddCustomer();
            //AddUser();
            //Test1();
            //carService.Add(new Car { ModelYear = 2001, Description = "Test Verisidir", DailyPrice = 150, ColorId = 1, rentalId = 2 });
            //CarService carService = new CarService(new InMemoryCarDal());
            //foreach (var item in carService.GetAll())
            //{
            //    System.Console.WriteLine(item.Description);
            //} 
        }

        private static void AddCustomer()
        {
            CustomerService customerService = new CustomerService(new EfCustomerDal());
            customerService.Add(new Customer { UserId = 1, CompanyName = "TresserT A.Ş." });
        }
        private static void AddCar()
        {
            CarService customerService = new CarService(new EfCarDal());
            customerService.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "Test", ModelYear = 2013 });
        }

        private static void AddUser()
        {
            UserService userService = new UserService(new EfUserDal());
            userService.Add(new User { FirstName = "Çağrı", LastName = "Sert", Email = "cagri_sert_@outlook.com.tr", Password = "Ankara06." });
        }

        private static void Test1()
        {
            CarService carService = new CarService(new EfCarDal());
            var data = carService.GetCarsDetail();
            if (data.Success)
            {
                foreach (var item in data.Data)
                {
                    System.Console.WriteLine(item.Id + " " + item.ModelYear + " " + item.Description + " " + item.ColorName + " " + item.BrandName);
                }
                System.Console.WriteLine(data.Message);
            }
        }
    }
}
