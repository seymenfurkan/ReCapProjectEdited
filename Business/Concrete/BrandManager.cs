using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult AddBrand(Brand brand)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
        }

        public IResult DeleteBrand(Brand brand)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _brandDal.Delete(brand);
                return new SuccessResult(Messages.BrandDeleted);
            }
        }

        public IDataResult <List<Brand>> GetAllBrands()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.ListOfBrands);
            }
        }

        public IDataResult <Brand> GetByBrand(int brandId)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<Brand>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId), Messages.ColorDetail);
            }
        }

        public IResult UpdateBrand(Brand brand)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdated);
            }
        }
    }
}
