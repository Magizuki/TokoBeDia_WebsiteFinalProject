using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Controller
{
    public class ProductTypeController
    {
        public static string ValidateNewProductType(String name, String description)
        {
            String Message = "";
            Boolean cekProductType = ProductTypeHandler.cekProductType(name);
            if (name.Equals("")||name.Length<5||!cekProductType)
            {
                Message = "Name must be filled, unique, and consists of 5 characters or more";
            }
            else if (description.Equals(""))
            {
                Message = "Description must be filled";
            }
            else
            {
                ProductTypeHandler.InsertNewProductType(name,description);
                Message = "Product Type successfully added to our database !";
            }

            return Message;

        }

        public static string ValidateUpdatedProductType(int id, String name, String description)
        {
            String Message = "";
            Boolean cekProductType = ProductTypeHandler.cekProductType(name);
            if (name.Equals("") || name.Length < 5 || !cekProductType)
            {
                Message = "Name must be filled, unique, and consists of 5 characters or more";
            }
            else if (description.Equals(""))
            {
                Message = "Description must be filled";
            }
            else
            {
                ProductTypeHandler.UpdateProductType(id, name, description);
                Message = "Product Type successfully added to our database !";
            }

            return Message;

        }
    }
}