using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Factory;
using FinalProject_TokoBeDia.Repository;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Handler
{
    public class ProductHandler
    {
        public static void InsertNewProduct(String name, int stock, int price)
        {
           ProductRepository.InsertNewProduct(ProductFactory.InsertNewProduct(name, stock, price));
        }

        public static object GetAllProductInfo()
        {
            return ProductRepository.GetAllProductInfo();
        }

        public static int GetStock(int idProduk)
        {
            return ProductRepository.GetStock(idProduk);
        }

        public static object GetProductInfoByID(int id)
        {
            return ProductRepository.GetProductInfoByID(id);
        }

        public static void DeleteProduct(int id)
        {
            ProductRepository.DeleteProduct(id);
        }

        public static void UpdateProduct(int id, String name, int stock, int price)
        {
            ProductRepository.UpdateProduct(id, name, stock, price);
        }

        public static List<Product> GetProductByID(int id)
        {
            return ProductRepository.GetProductByID(id);
        }

        public static void DeleteProductByProductTypeID(int id)
        {
            ProductRepository.DeleteProductByProductTypeID(id);
        }

        public static object GetProductRecommendation()
        {
            return ProductRepository.GetProductRecommendation();
        }
    }
}