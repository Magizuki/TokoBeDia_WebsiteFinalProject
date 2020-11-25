using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType InsertNewProductType(String name, String description)
        {
            ProductType type = new ProductType();
            type.ProductTypeName = name;
            type.ProductTypeDescription = description;

            return type;
        }

    }
}