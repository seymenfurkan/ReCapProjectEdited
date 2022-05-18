using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            _carDal.Add(car);
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
            return _carDal.GetByBrandId(brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            // Şartlar vs. vs.
            return _carDal.GetByColorId(colorId);
        }

        public void UpdateCar(Car car)
        {
            // Şartlar vs. vs.
            _carDal.Update(car);
        }
    }
}
