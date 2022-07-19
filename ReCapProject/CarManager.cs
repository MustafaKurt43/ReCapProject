using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject
{
    public class CarManager : ICarServices, ICarDal
    {
        ICarDal _carDal;
        private InMemoryThing ınMemoryThing;

        public CarManager(CarManager carDal)
        {
            _carDal = carDal;
        }

        public CarManager(InMemoryThing ınMemoryThing)
        {
            this.ınMemoryThing = ınMemoryThing;
        }

        public void Add(CarBase car)
        {
               
            Console.WriteLine("Eklendi");
        }

        public void Delete(CarBase car)
        {
            _carDal.Delete(car);
        }

        public List<CarBase> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarBase> GetByBrandId(int BrandId)
        {
            return _carDal.GetByBrandId(BrandId);

        }

        public List<CarBase> GetByColorId(int ColorId)
        {
            return _carDal.GetByColorId(ColorId);

        }

        public void Update(CarBase car)
        {
            Console.WriteLine("Güncellendi");

        }
    }
}
