using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Controller
{
    public class ProductController
    {

        public static string ValidateNewProduct(String name, int stock, int price)
        {
            String Message = "";
            if (name.Equals(""))
            {
                Message = "Name must be filled";
            }
            else if (stock < 1)
            {
                Message = "Stock input must be 1 or more";
            }
            else if (price < 1000 || price % 1000 != 0)
            {
                Message = "Price input must be above 1000 and multiply of 1000";
            }
            else
            {
                ProductHandler.InsertNewProduct(name, stock, price);
                Message = "Product successfully added to our database !";
            }

            return Message;

        }

        public static string ValidateUpdatedProduct(int id, String name, int stock, int price)
        {
            String Message = "";
            if (name.Equals(""))
            {
                Message = "Name must be filled";
            }
            else if (stock < 1)
            {
                Message = "Stock input must be 1 or more";
            }
            else if (price < 1000 || price % 1000 != 0)
            {
                Message = "Price input must be above 1000 and multiply of 1000";
            }
            else
            {
                ProductHandler.UpdateProduct(id, name, stock, price);
                Message = "Product successfully Updated to our database !";
            }

            return Message;

        }


    }
}