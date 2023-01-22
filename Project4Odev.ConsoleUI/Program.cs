using Proje4Odev.Business;
using Proje4Odev.DataAccess;

namespace Project4Odev.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EntityCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Marka + " " + car.Model);
            }

            Console.WriteLine("*******************************************");

            carManager = new CarManager(new AdoCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Marka + " " + car.Model);
            }
        }
    }
}