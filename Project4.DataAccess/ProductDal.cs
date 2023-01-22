using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Project4.Entities;

namespace Project4.DataAccess
{
    public class ProductDal:IProductDal
    {
        private List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "Acer Bilgisayar", QuantityPerUnit = "32 Gb Ram", UnitPrice = 10000, UnitsInStock = 5},
                new Product{ProductId = 2, ProductName = "HP Bilgisayar", QuantityPerUnit = "64 Gb Ram", UnitPrice = 12000, UnitsInStock = 4},
                new Product{ProductId = 3, ProductName = "IBM Bilgisayar", QuantityPerUnit = "16 Gb Ram", UnitPrice = 11000, UnitsInStock = 6},
                new Product{ProductId = 4, ProductName = "Lenovo Bilgisayar", QuantityPerUnit = "64 Gb Ram", UnitPrice = 10500, UnitsInStock = 5},
                new Product{ProductId = 5, ProductName = "Asus Bilgisayar", QuantityPerUnit = "32 Gb Ram", UnitPrice = 9000, UnitsInStock = 3}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
            Console.WriteLine("ADO.Net ile eklendi...");
        }
    }
}
