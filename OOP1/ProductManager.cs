﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add()
        {
            Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2= new Product { Id=2, CategoryId = 3, UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };
        }
    }
}
