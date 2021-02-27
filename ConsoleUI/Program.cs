using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName + car.Descriptions );
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine( car.CarName+" " +car.Descriptions+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }
            Console.WriteLine("-------------");

            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.CarName);
            }

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User{UserId=3,FisrtName="Gonca",LastName="Üstünay",Email="gonca@email.com",Password="1112233" });
            


            
        }
    }
}
