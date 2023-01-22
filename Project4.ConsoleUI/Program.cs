// See https://aka.ms/new-console-template for more information

using Project4.Business;
using Project4.DataAccess;

ProductManager productManager = new ProductManager(new XFProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}