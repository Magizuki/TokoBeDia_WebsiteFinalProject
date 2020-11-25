using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Factory
{
    public class TransactionFactory
    {

        public static HeaderTransaction CreateHeaderTransaction(int Userid, int paymentTypeID )
        {
            HeaderTransaction Htransaction = new HeaderTransaction();
            Htransaction.UserID = Userid;
            Htransaction.PaymentTypeID = paymentTypeID;
            Htransaction.Date = DateTime.Now;

            return Htransaction;
        }

        public static DetailTransaction CreateDetailTransaction(int idProduk,int Htrans,int quantity)
        {
            DetailTransaction Dtransaction = new DetailTransaction();
            Dtransaction.ProductID = idProduk;
            Dtransaction.Quantity = quantity;
            Dtransaction.HeaderTransactionID = Htrans;

            return Dtransaction;
        }



    }
}