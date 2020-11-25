using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Repository
{
    public class PaymentTypeRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static void InsertNewPaymentType(PaymentType paymentType)
        {
            db.PaymentTypes.Add(paymentType);
            db.SaveChanges();
        }

        public static List<PaymentType> GetPaymentTypeByName(String name)
        {
            return (from x in db.PaymentTypes where x.PaymentTypeName == name select x).ToList();
        }

        public static List<PaymentType> GetAllPaymentTypeInfo()
        {
            return (from x in db.PaymentTypes select x).ToList();
        }

        public static int getPaymentID(String name)
        {
            return db.PaymentTypes.Where(PaymentType => PaymentType.PaymentTypeName == name).Select(PaymentType => PaymentType.PaymentTypeID).FirstOrDefault();
        }

        public static void DeletePaymentType(String name)
        {
            PaymentType paymentType = (from x in db.PaymentTypes where x.PaymentTypeName == name select x).FirstOrDefault();
            int id = getPaymentID(name);
            db.PaymentTypes.Remove(paymentType);
            var headertransaction = (from x in db.HeaderTransactions where x.PaymentTypeID == id select x).ToList();
            var detailtransaction = (from x in db.DetailTransactions join y in db.HeaderTransactions on x.HeaderTransactionID equals y.HeaderTransactionID where y.PaymentTypeID == id select x).ToList();

            foreach (var x in headertransaction)
            {
                db.HeaderTransactions.Remove(x);
            }

            foreach (var x in detailtransaction)
            {
                db.DetailTransactions.Remove(x);
            }
            db.SaveChanges();


        }

        public static void UpdatePaymentType(String nameBefore, String nameAfter)
        {
            PaymentType paymentType = (from x in db.PaymentTypes where x.PaymentTypeName == nameBefore select x).FirstOrDefault();
            paymentType.PaymentTypeName = nameAfter;
            db.SaveChanges();
        }

        public static Boolean cekNama(String name)
        {
            PaymentType nama = (from x in db.PaymentTypes where x.PaymentTypeName == name select x).FirstOrDefault();

            if (nama == null)
            {
                return true;
            }

            return false;

        }




    }
}