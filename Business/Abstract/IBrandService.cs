﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult AddBrand(Brand brand);
        IResult DeleteBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IDataResult <Brand> GetByBrand(int brandId);

        IDataResult <List<Brand>> GetAllBrands();
        

    }
}
