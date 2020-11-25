using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Repository
{
    public class CartRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static void AddCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();

        }

        public static int GetSum(int idProduk)
        {
            int sum = 0;
            var cart = (from x in db.Carts where x.ProductID == idProduk select x);

            foreach(var x in cart)
            {
                sum = sum + x.Quantity;
            }

            return sum;
        }

        

        public static object GetCartDetailInfo(String email)
        {
            int id = UserHandler.getUserID(email);
            var cart = (from x in db.Carts
                        join y in db.Products on x.ProductID equals y.ProductID
                        where  x.UserID == id
                        select new
                        {
                            x.ProductID,
                            y.ProductName,
                            y.ProductPrice,
                            x.Quantity,
                            SubTotal =x.Quantity*y.ProductPrice
                        }).ToList();

            return cart;

        }

        public static Boolean cekCart(String email, int idProduk)
        {
            int id = UserHandler.getUserID(email);
            Cart cart = (from x in db.Carts where x.UserID == id && x.ProductID == idProduk select x).FirstOrDefault();

            if(cart == null)
            {
                return true;
            }

            return false;

        }

        public static void AddQuantity(String email, int idProduk, int quantity)
        {
            int id = UserHandler.getUserID(email);
            Cart cart = (from x in db.Carts where x.UserID == id && x.ProductID == idProduk select x).FirstOrDefault();
            cart.Quantity = cart.Quantity + quantity;
            db.SaveChanges();

        }

        public static void AddNewQuantity(String email, int idProduk, int quantity)
        {
            int id = UserHandler.getUserID(email);
            Cart cart = (from x in db.Carts where x.UserID == id && x.ProductID == idProduk select x).FirstOrDefault();
            cart.Quantity = quantity;
            db.SaveChanges();
        }

        public static object getCartByID(String email, int idProduk)
        {
            int id = UserHandler.getUserID(email);
            var cart = (from x in db.Carts join y in db.Products on x.ProductID equals y.ProductID
                        where x.UserID == id && x.ProductID == idProduk
                        select new
                        {
                            y.ProductName,
                            x.Quantity
                        }).ToList();

            return cart;
        }

        public static void DeleteCart(String email, int idProduk)
        {
            int id = UserHandler.getUserID(email);
            Cart cart = (from x in db.Carts where x.UserID == id && x.ProductID == idProduk select x).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static void DeleteAllCart(String email)
        {
            int id = UserHandler.getUserID(email);
            var cart = (from x in db.Carts where x.UserID == id  select x).ToList();


            foreach( var x in cart)
            {
                db.Carts.Remove(x);
            }

            db.SaveChanges();
        }

        public static int GetQuantity(String email, int idProduk)
        {
            int id = UserHandler.getUserID(email);
            return (from x in db.Carts where x.UserID == id && x.ProductID == idProduk select x.Quantity).FirstOrDefault();
        }

        public static int GetGrandTotal(String email)
        {
            int id = UserHandler.getUserID(email);
            int sum = 0;

            var cart = (from x in db.Carts  where  x.UserID == id select x).ToList();
            

            foreach(var x in cart)
            {
                int productPrice = db.Products.Where(Product=>Product.ProductID==x.ProductID).Select(Product=>Product.ProductPrice).FirstOrDefault();
                sum = sum + (x.Quantity * productPrice);
            }

            return sum;

        }

    }
}