using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject
{
    internal interface ICarDal
    {
        void Add(CarBase car);
        void Update(CarBase car);
        void Delete(CarBase car);
        List<CarBase> GetByBrandId(int BrandId);
        List<CarBase> GetByColorId(int ColorId);
        List<CarBase> GetAll();
    }
}