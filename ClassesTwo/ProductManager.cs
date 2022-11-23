using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTwo
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName);
        }

        public void Delete()
        {
            Console.WriteLine("Ürün silindi...");
        }
    }
}
