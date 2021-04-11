using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            */
            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car{CarId =1,CarName="Audi A6" ,BrandId = 1,ColorId = 1,DailyPrice = 100,Description = "Temiz araç",ModelYear = 2016};
            //Car car2 = new Car{CarId=2,CarName="Audi A3" ,BrandId = 1,ColorId = 2,DailyPrice = 200,Description = "Sahibinden Temiz Araç",ModelYear = 2019};
            //Car car3 = new Car{ CarId = 3, CarName = "Audi A5" ,BrandId = 3,ColorId = 2,DailyPrice = 300,Description = "Hata Kaza Değişen Yok! Sadece 2 parça boyalı geyik çarptı :)",ModelYear = 2009};
            //Car car4 = new Car { CarId = 4, CarName = "Audi A4" ,BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "kirli araç", ModelYear = 2016 };
            ////carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Add(car3);
            //carManager.Add(car4);
            //carManager.GetCarsByBrandId(3);
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color1 = new Color { ColorId = 1,ColorName= "Beyaz" };
            //Color color2 = new Color { ColorId = 2, ColorName = "Siyah" };
            ////colorManager.Add(color1);
            //colorManager.Add(color2);
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand1 = new Brand { BrandId = 1, BrandName = "Audi" };
            //Brand brand2 = new Brand { BrandId = 3, BrandName = "Fiat" };
            ////brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //foreach (var car in IDataResult(carManager.GetCarDetails)())
            //{
            //    Console.WriteLine(car.CarName + "/" + car.ColorName+"/"+car.BrandName+"/"+car.DailyPrice);
            //}
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("Color Name :" + color.ColorName);

            //}
            ////carManager.Delete(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Car Description :" + car.Description);

            //}
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine("Car Description :" + car.Description);

            //}
        }
    }
}
