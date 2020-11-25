using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Repository
{
    public class ProductTypeRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static Boolean cekProductType(String name)
        {
            ProductType productType = (from x in db.ProductTypes where x.ProductTypeName == name select x).FirstOrDefault();

            if(productType == null)
            {
                return true;
            }

            return false;
        }

        public static void InsertNewProductType(ProductType productType)
        {
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }

        public static List<ProductType> GetAllProductTypeInfo()
        {
            return db.ProductTypes.ToList();
        }

        public static List<ProductType> GetProductTypeByID(int id)
        {
            return db.ProductTypes.Where(ProductType => ProductType.ProductTypeID == id).ToList();
        }

        public static void DeleteProductType(int id)
        {
            ProductType productType = (from x in db.ProductTypes where x.ProductTypeID == id select x).FirstOrDefault();
            db.ProductTypes.Remove(productType);
            ProductHandler.DeleteProductByProductTypeID(id);
            db.SaveChanges();
            
        }

        public static void UpdateProductType(int id, String name, String description)
        {
            ProductType productType = (from x in db.ProductTypes where x.ProductTypeID == id select x).FirstOrDefault();
            productType.ProductTypeName = name;
            productType.ProductTypeDescription = description;
            db.SaveChanges();

        }

    }
}