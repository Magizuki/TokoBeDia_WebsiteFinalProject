using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Repository;
using FinalProject_TokoBeDia.Factory;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Handler
{
    public class TransactionHandler
    {

        public static void AddHeaderTransaction(String email, String payment)
        {
            int Userid = UserHandler.getUserID(email);
            int Idpayment = PaymentTypeHandler.getPaymentID(payment);

            TransactionRepository.AddHeaderTransaction(TransactionFactory.CreateHeaderTransaction(Userid, Idpayment));
        }

        public static List<HeaderTransaction> GetTransaction()
        {
            return TransactionRepository.GetTransaction();
        }

        public static void AddDetailTransaction(String email, int idProduk)
        {
            
            int quantity = CartHandler.GetQuantity(email, idProduk);
            int HTransID = GetTransactionID();
            TransactionRepository.AddDetailTransaction(TransactionFactory.CreateDetailTransaction(idProduk, HTransID, quantity));
        }

        public static int GetTransactionID()
        {
           return TransactionRepository.GetTransactionID();
        }

        public static void AddNewTransaction(String email)
        {
            TransactionRepository.AddNewTransaction(email);
        }

        public static object GetAllTransactionViaMember(String email)
        {
            return TransactionRepository.GetAllTransactionViaMember(email);
        }

        public static object GetAllTransactionInfoViaAdmin()
        {
            return TransactionRepository.GetAllTransactionInfoViaAdmin();
        }


    }
}