using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4Odev.Entities;

namespace Proje4Odev.DataAccess
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
    }
}
