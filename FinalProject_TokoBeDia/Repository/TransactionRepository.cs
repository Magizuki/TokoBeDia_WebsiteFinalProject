using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Repository
{
    public class TransactionRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static void AddNewTransaction(String email)
        {

            int id = UserHandler.getUserID(email);

            var cart = (from x in db.Carts 
                        where x.UserID == id select x ).ToList();

            foreach(var x in cart)
            {
                TransactionHandler.AddDetailTransaction(email, x.ProductID);
               
            }

        }

        public static List<HeaderTransaction> GetTransaction()
        {
            return db.HeaderTransactions.ToList();
        }

        public static int GetTransactionID ()
        {
            return db.HeaderTransactions.OrderByDescending(HeaderTransaction=>HeaderTransaction.HeaderTransactionID).Select(HeaderTransaction => HeaderTransaction.HeaderTransactionID).FirstOrDefault();
        }

        public static void AddHeaderTransaction(HeaderTransaction HTrans)
        {
            db.HeaderTransactions.Add(HTrans);
            db.SaveChanges();

        }

        public static void AddDetailTransaction(DetailTransaction DTrans)
        {
            db.DetailTransactions.Add(DTrans);
            db.SaveChanges();

        }

        public static object GetAllTransactionInfoViaAdmin()
        {
            var Transaction = (from x in db.DetailTransactions
                               join y in db.HeaderTransactions on x.HeaderTransactionID equals y.HeaderTransactionID
                               join z in db.PaymentTypes on y.PaymentTypeID equals z.PaymentTypeID
                               join w in db.Products on x.ProductID equals w.ProductID
                               join o in db.Users on y.UserID equals o.UserID
                               select new
                               {
                                   x.HeaderTransactionID,
                                   y.Date,
                                   y.UserID,
                                   o.UserName,
                                   z.PaymentTypeName,
                                   x.ProductID,
                                   w.ProductName,
                                   x.Quantity,
                                   w.ProductPrice,
                                   Subtotal = x.Quantity * w.ProductPrice
                               }).ToList();

            return Transaction;
        }

        public static object GetAllTransactionViaMember(String email)
        {
            int id = UserHandler.getUserID(email);

            var Transaction = (from x in db.DetailTransactions
                               join y in db.HeaderTransactions on x.HeaderTransactionID equals y.HeaderTransactionID
                               join z in db.PaymentTypes on y.PaymentTypeID equals z.PaymentTypeID
                               join w in db.Products on x.ProductID equals w.ProductID
                               where y.UserID == id
                               select new
                               {
                                   x.HeaderTransactionID,
                                   y.Date,
                                   y.UserID,
                                   z.PaymentTypeName,
                                   x.ProductID,
                                   w.ProductName,
                                   x.Quantity,
                                   w.ProductPrice,
                                   Subtotal = x.Quantity * w.ProductPrice
                               }).ToList();

            return Transaction;

        }
 
    }
}