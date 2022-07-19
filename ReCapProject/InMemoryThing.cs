using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapProject
{
    class InMemoryThing : ICarDal
    {
        List<CarBase> _cars;
        public InMemoryThing()
        {
            _cars = new List<CarBase> {
            new CarBase{CarId=1,BrandId=3,ColorId=1,DailyPrice=200,Description="araba1",ModelYear=2001},
            new CarBase{CarId=2,BrandId=1,ColorId=1,DailyPrice=400,Description="araba2",ModelYear=2002},
            new CarBase{CarId=3,BrandId=2,ColorId=1,DailyPrice=250,Description="araba3",ModelYear=2003},
            };
     
        }

        public void Add(CarBase car)
        {
            _cars.Add(car);
        }

        public void Delete(CarBase car)
        {
            CarBase carToDelete;
            carToDelete = _cars.SingleOrDefault(car => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<CarBase> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CarBase> GetByBrandId(int BrandId)
        {
            throw new NotImplementedException();
        }

        public List<CarBase> GetByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public void Update(CarBase car)
        {
            throw new NotImplementedException();
        }
    }
}
