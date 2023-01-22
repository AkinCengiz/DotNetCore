using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4Odev.Entities;

namespace Proje4Odev.DataAccess
{
    public class EntityCarDal:ICarDal
    {
        private List<Car> _cars;
        public EntityCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1, Marka = "Mercedes Entity", Model = "A180", UnitPrice = 300000 },
                new Car { Id = 2, Marka = "BMW Entity", Model = "1.18", UnitPrice = 320000 },
                new Car { Id = 3, Marka = "Volkswagen Entity", Model = "Golf", UnitPrice = 280000 },
                new Car { Id = 4, Marka = "Opel Entity", Model = "Astra", UnitPrice = 290000 },
                new Car { Id = 5, Marka = "Toyota Entity", Model = "Corolla", UnitPrice = 295000 }
            };
        }
        
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Entity ile eklendi....");
        }
    }
}
