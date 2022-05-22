using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            // Şartlar vs. vs.
            if(car.Description.Length<=2 || car.DailyPrice < 0)
            {
                if (car.Description.Length<2)
                {
                    Console.WriteLine("Eklenecek aracın ismi minimum 2 karakter olmalıdır!");
                }
                if (car.DailyPrice<=0)
                {
                    Console.WriteLine("Eklenecek aracın fiyatı 0'dan büyük olmalıdır");
                }
            }
            else
            {
                Console.WriteLine("Araç veri tabanına kaydedildi!\n");
                _carDal.Add(car);
                
            }
            
        }

        public void DeleteCar(Car car)
        {
            // Şartlar vs. vs.
            _carDal.Delete(car);
        }

        public List<Car> GetAllCar()
        {
            // Şartlar vs. vs.
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            // Şartlar vs. vs.
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public Car GetById(int carId)
        {
           return _carDal.Get(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void UpdateCar(Car car)
        {
            // Şartlar vs. vs.
            _carDal.Update(car);
        }
    }
}
