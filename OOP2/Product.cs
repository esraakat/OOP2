using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Product
    {
        //snippet - prepared codes
        public int ProductId { get; set; }
        public int CategoryId { get; set; } //Write here for reading code.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
//There are only property in this class.
//CRUD functions - CREAT, READ, UPPDATE, DELETE