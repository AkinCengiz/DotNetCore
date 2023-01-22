using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proje4Odev.DataAccess;
using Project4Odev.Entities;

namespace Proje4Odev.Business
{
    public class CarManager
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }
    }
}
