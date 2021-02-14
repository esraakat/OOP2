using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.CategoryId = 2; //furniture
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //You can write like this instead of 
            Product product2 = new Product() { ProductId = 2, CategoryId = 5, 
                UnitInStock = 5, ProductName = "Pencil", UnitPrice = 35};

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Delete(product1);
            productManager.Delete(product2);
            productManager.Update(product1);
            productManager.Update(product2);

        }
    }
}
//Case sensitive 
//ref - out
//There are 2 types of class. There are properties in one of the classes, methods in another class.
