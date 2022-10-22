using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("Id:"+cars.Id+"  BrandId:"+cars.BrandId+"  ColorId:"+cars.ColorId+"  Üretim Yılı:"+cars.ModelYear+"  Günlük Fiyatı:"+cars.DailyPrice+"  Açıklama:"+cars.Description);
            }

            
            Car newCar = new Car() 
            {Id=7,BrandId=212,ColorId=222,ModelYear="2001",DailyPrice=320,Description="Kısaca güzel arabadır."};
           

        }
    }
}
