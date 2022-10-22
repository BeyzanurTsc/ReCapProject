using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {  
                new Car{Id=1,BrandId=42,ColorId=333,ModelYear="2004",DailyPrice=350,Description="Volkswagen Jetta"},
                new Car{Id=2,BrandId=42,ColorId=555,ModelYear="2012",DailyPrice=400,Description="Renault Megan,sedan kasa"},
                new Car{Id=3,BrandId=32,ColorId=222,ModelYear="2019",DailyPrice=370,Description="Hyundai i20 Otomatik Vites Benzinli"},
                new Car{Id=4,BrandId=32,ColorId=222,ModelYear="2000",DailyPrice=550,Description="Fiat Egea 2020 model sedan kasa"},
                new Car{Id=5,BrandId=32,ColorId=555,ModelYear="2021",DailyPrice=500,Description="Fiat Egea manuel vites"},
                new Car{Id=6,BrandId=42,ColorId=333,ModelYear="2010",DailyPrice=435,Description="BMV 5 serisi otomatik vites"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.BrandId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
