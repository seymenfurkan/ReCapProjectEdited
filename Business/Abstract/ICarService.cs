using Core.Utilities.Results.Abstract;
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
        IDataResult <List<Car>> GetAllCar();
        IResult AddCar(Car car);
        IResult UpdateCar(Car car);
        IResult DeleteCar(Car car);
        List<Car> GetByColorId(int colorId);
        List<Car> GetByBrandId(int brandId);
        IDataResult <Car> GetById(int carId);

        IDataResult <List<CarDetailDto>> GetCarDetails();
    }
}
