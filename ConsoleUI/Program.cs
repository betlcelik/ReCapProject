using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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

            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var car in carManager1.GetCarDetails())
            {
                Console.WriteLine( car.CarName+" " +car.Descriptions+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }

            


            
            
            
        }
    }
}
