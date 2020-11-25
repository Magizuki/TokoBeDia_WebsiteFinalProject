using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Repository;
using FinalProject_TokoBeDia.Factory;
using FinalProject_TokoBeDia.Model;


namespace FinalProject_TokoBeDia.Handler
{
    public class ProductTypeHandler
    {
        public static Boolean cekProductType(String name)
        {
            return ProductTypeRepository.cekProductType(name);
        }

        public static void InsertNewProductType(String name, String description)
        {
            ProductTypeRepository.InsertNewProductType(ProductTypeFactory.InsertNewProductType(name, description));
        }

        public static List<ProductType> GetAllProductTypeInfo()
        {
            return ProductTypeRepository.GetAllProductTypeInfo();
        }

        public static List<ProductType> GetProductTypeByID(int id)
        {
            return ProductTypeRepository.GetProductTypeByID(id);
        }

        public static void DeleteProductType(int id)
        {
            ProductTypeRepository.DeleteProductType(id);
        }

        public static void UpdateProductType(int id, String name, String description)
        {
            ProductTypeRepository.UpdateProductType(id, name, description);
        }

    }
}