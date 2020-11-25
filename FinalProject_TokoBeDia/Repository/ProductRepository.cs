using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Repository
{
    public class ProductRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static void InsertNewProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static List<Product> GetProductByID (int id)
        {
            return db.Products.Where(Product => Product.ProductID == id).ToList();
        }

        public static object GetAllProductInfo()
        {

            var productInfo = (from x in db.Products
                               join y in db.ProductTypes on x.ProductTypeID equals y.ProductTypeID
                               select new
                               {
                                   x.ProductID,
                                   x.ProductName,
                                   x.ProductStock,
                                   y.ProductTypeName,
                                  
                               }
                                   ).ToList();
            return productInfo;

        }

        public static object GetProductInfoByID(int id)
        {

            var productInfo = (from x in db.Products
                               join y in db.ProductTypes on x.ProductTypeID equals y.ProductTypeID
                               where x.ProductID == id
                               select new
                               {
                                   
                                   x.ProductName,
                                   x.ProductPrice,
                                   x.ProductStock,
                                   y.ProductTypeName
                                   
                               }
                                   ).ToList();
            return productInfo;

        }

        public static int GetStock(int idProduk)
        {
            return  db.Products.Where(Product=>Product.ProductID==idProduk).Select(Product=>Product.ProductStock).FirstOrDefault();
        }


        public static object GetProductRecommendation()
        {
            return db.Products.Select(Product => new { Product.ProductName, Product.ProductID } ).Take(5).ToArray();
        }

        public static void DeleteProduct(int id)
        {
            Product product = (from x in db.Products where x.ProductID == id select x).FirstOrDefault();
            var cart = (from x in db.Carts where x.ProductID == id select x);
            var DTrans = (from x in db.DetailTransactions where x.ProductID == id select x);
            db.Products.Remove(product);
            
            foreach(var x in cart)
            {
                db.Carts.Remove(x);
            }

            foreach (var x in DTrans)
            {
                db.DetailTransactions.Remove(x);
            }

            db.SaveChanges();
        }

        public static void DeleteProductByProductTypeID(int id)
        {
            var product = (from x in db.Products where x.ProductTypeID == id select x).ToList();
            var cart = (from x in db.Carts join y in db.Products on x.ProductID equals y.ProductID where y.ProductTypeID == id select x).ToList();
            var DTrans = (from x in db.DetailTransactions join y in db.Products on x.ProductID equals y.ProductID where y.ProductTypeID == id select x).ToList();


            foreach (var x in product)
            {
                db.Products.Remove(x);
            }

            foreach (var x in cart)
            {
                db.Carts.Remove(x);
            }

            foreach(var x in DTrans)
            {
                db.DetailTransactions.Remove(x);
            }

            
            db.SaveChanges();
        }

        public static void UpdateProduct(int id, String name, int stock, int price)
        {
            Product product = (from x in db.Products where x.ProductID == id select x).FirstOrDefault();
            product.ProductName = name;
            product.ProductStock = stock;
            product.ProductPrice = price;
            db.SaveChanges();
        }
    }
}