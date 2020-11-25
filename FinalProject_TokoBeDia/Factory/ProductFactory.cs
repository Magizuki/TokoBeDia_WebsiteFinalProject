using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Factory
{
    public class ProductFactory
    {
        public static Product InsertNewProduct(String name, int stock, int price)
        {
            Product product = new Product();
            product.ProductTypeID = 1;
            product.ProductName = name;
            product.ProductStock = stock;
            product.ProductPrice = price;

            return product;
        }
        

    }
}