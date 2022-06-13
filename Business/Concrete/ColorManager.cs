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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult AddColor(Color color)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _colorDal.Add(color);
                return new SuccessResult (Messages.ColorAdded);
            }
        }

        public IResult DeleteColor(Color color)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _colorDal.Delete(color);
                return new SuccessResult(Messages.ColorDeleted);
            }
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Color>> (_colorDal.GetAll(),Messages.ListOfColors);
            }
        }

        public IDataResult <Color> GetByColor(int colorId)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<Color>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<Color> (_colorDal.Get(c => c.ColorId == colorId),Messages.ColorDetail);
            }
        }

        public IResult UpdateColor(Color color)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _colorDal.Update(color);
                return new SuccessResult(Messages.ColorUpdated);
            }
        }
    }
}
