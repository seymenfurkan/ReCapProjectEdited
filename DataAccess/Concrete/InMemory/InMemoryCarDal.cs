using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear="2022", DailyPrice=300, Description="Fiat Egea"  },
                new Car {Id=2, BrandId=2, ColorId=2, ModelYear="2021", DailyPrice=280, Description="Ford Focus" },
                new Car {Id=3, BrandId=3, ColorId=2, ModelYear="2020", DailyPrice=275, Description="Opel Astra" },
                new Car {Id=4, BrandId=4, ColorId=3, ModelYear="2020", DailyPrice=340, Description="Audi A4"},
                new Car {Id=5, BrandId=5, ColorId=3, ModelYear="2017", DailyPrice=200, Description="Renault Megane"},
                new Car {Id=6, BrandId=3, ColorId=1, ModelYear="2020", DailyPrice=245, Description="Opel Vectra"},
                new Car {Id=7, BrandId=4, ColorId=2, ModelYear="2019", DailyPrice=500, Description="Audi RS 8"},
                new Car {Id=8, BrandId=2, ColorId=4, ModelYear="2023", DailyPrice=640, Description="Ford Mustang"}
             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            
            return _cars.Where(c => c.ColorId == colorId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
