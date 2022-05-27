using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult AddCar(Car car)
        {
                    
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            
                   
        }

        public IResult DeleteCar(Car car)
        {
            if (DateTime.Now.Hour==17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
             _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
            
        }

        public IDataResult<List<Car>> GetAllCar()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Car>> (_carDal.GetAll(), Messages.ListOfCars);
            }
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

        public IDataResult <Car> GetById(int carId)
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<Car>(Messages.MaintenanceTime);
            }
            else
            {
                 return new SuccessDataResult<Car> (_carDal.Get(c => c.CarId == carId),Messages.CarInfo);
            }
        }

        public IDataResult <List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            else
            {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails());
            }
        }

        public IResult UpdateCar(Car car)
        {
            if (DateTime.Now.Hour== 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
            _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
        }
    }
}
