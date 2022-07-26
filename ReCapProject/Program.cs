﻿using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryThing());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------------------------");

            carManager.Add(new CarBase { CarId = 5, BrandId = 3, ColorId = 1, DailyPrice = 300, Description = "lambo beyaz 2015", ModelYear = 2015 });
            carManager.Add(new CarBase { CarId = 6, BrandId = 3, ColorId = 2, DailyPrice = 0, Description = "lambo siyah 2020", ModelYear = 2020 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------------------------");

            carManager.Update(new CarBase { CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 600, Description = "lambo siyah 2020", ModelYear = 2020 });
            carManager.Update(new CarBase { CarId = 6, BrandId = 3, ColorId = 1, DailyPrice = 300, Description = "lambo beyaz 2015", ModelYear = 2015 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------------------------");

            int brandId;
            brandId = Convert.ToInt32(Console.ReadLine());
            foreach (var car in carManager.GetByBrandId(brandId))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------------------------");

            int colorId;
            colorId = Convert.ToInt32(Console.ReadLine());
            foreach (var car in carManager.GetByColorId(colorId))
            {
                Console.WriteLine(car.Description);
            }
        }

    }


}
