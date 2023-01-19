using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
            new Car { Id = 1 ,BrandId = 3, ColorId = 1, ModelYear = 2018, DailyPrice = 1000000, Description = "Audi" },
            new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2014, DailyPrice = 280000, Description = "Renault" },
            new Car { Id = 3, BrandId =5 , ColorId = 1, ModelYear = 2017, DailyPrice = 900000, Description = "BMW" },
            new Car { Id = 4, BrandId =6 , ColorId = 3, ModelYear = 2023, DailyPrice = 1000000, Description ="Mercedes" },
            new Car { Id = 5, BrandId =7 , ColorId = 4, ModelYear = 2011, DailyPrice = 250000, Description = "Fiat"}
            };
        }

        public void Add(Car car)
        {
          cars.Add(car);    
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id); //LINQ Kullandık.
            cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int id)
        {
            return cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id); //LINQ Kullandık.
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ModelYear=car.ModelYear;    
            carToUpdate.DailyPrice=car.DailyPrice;  
            carToUpdate.Description=car.Description;    
            carToUpdate.Id=car.Id;
            carToUpdate.ColorId=car.ColorId;
       
        }
    }
}
