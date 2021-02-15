using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
     public interface ICarDal
    {
        List<Car> GetAll();
        //DataAccess sağ tık > add project reference (entities)
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int Id);

    }
}
