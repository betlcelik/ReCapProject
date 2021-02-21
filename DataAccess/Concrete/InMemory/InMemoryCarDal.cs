using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //Class içinde methodlar dışında(global "_" kullanılır)
        public InMemoryCarDal() //constructor
        {
            _cars = new List<Car> {
                new Car
                {
                    Id=1,
                    BrandId=1,
                    ColorId=1,
                    ModelYear="2012",
                    DailyPrice=100,
                    Descriptions="Ford Focus"
                },
                  new Car
                {
                    Id=2,
                    BrandId=2,
                    ColorId=2,
                    ModelYear="2015",
                    DailyPrice=2000,
                    Descriptions="BMW"
                },
                    new Car
                {
                    Id=3,
                    BrandId=3,
                    ColorId=2,
                    ModelYear="2016",
                    DailyPrice=500,
                    Descriptions="Audi"
                },



            };    
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           // Car carToDelete = null;
            //foreach (var c in _cars)
            //{
            //    if (car.Id==c.Id)
            //    {
            //        carToDelete = c;
            //    }
            //}
            //_cars.Remove(carToDelete);
           Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
                _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
          return _cars.Where(c=>c.Id== Id).ToList();
         // where yeni bir liste haline getirip onu döndürür
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
          Car  carToUpdate = _cars.SingleOrDefault(c => c.Id  ==car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }
    }
}
