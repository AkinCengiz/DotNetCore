using ClassesTwo;

Product product = new Product()
{
    Id = 1,
    ProductName = "Laptop",
    UnitPrice = 2500,
    UnitsInStock = 35
};

ProductManager productManager = new ProductManager();
productManager.Add(product);