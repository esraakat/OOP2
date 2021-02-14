using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ProductManager
    {
        //encapsulation
        public void Add (Product product)
        {
            Console.WriteLine(product.ProductName + " was added.");
        }
        public void Delete (Product product)
        {
            Console.WriteLine(product.ProductName + " was deleted.");
        }
        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " was updated.");
        }
    }
}
//There are methods for product like adding, deleting, updating... in this class.