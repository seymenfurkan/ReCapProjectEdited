using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void AddColor(Color color);
        void DeleteColor(Color color);
        void UpdateColor(Color color);
        Color GetByColor(int colorId);
        List<Color> GetAllColors();
       


    }
}
