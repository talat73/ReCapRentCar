using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //test();

            Car car1 = new Car()
            {
              ModelYear="2021",
              ColorId = 2,
              BrandId = 1,
              DailyPrice = 200,
              Description = "Brabus 800 G63"
            };
            carManager.AddCar(car1);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.BrandName} - {car.CarName} - {car.ColorName} - {car.DailyPrice}");
            }

        }

        private static void test()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Color addColor = new Color() { ColorName = "Red" };
            //Color addColor1 = new Color() { ColorName = "Black" };
            //colorManager.Add(addColor);
            //colorManager.Add(addColor1);
            //Color deleteColor = new Color() { ColorId = 1, ColorName = "Black" };
            //colorManager.Delete(deleteColor);

            foreach (var car in colorManager.GetAll())
            {
                Console.WriteLine(car.ColorName);
            }
        }
    }
}
