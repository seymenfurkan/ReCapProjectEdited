using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCar();
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
        List<Car> GetByColorId(int colorId);
        List<Car> GetByBrandId(int brandId);
        Car GetById(int carId);

        List<CarDetailDto> GetCarDetails();
    }
}
