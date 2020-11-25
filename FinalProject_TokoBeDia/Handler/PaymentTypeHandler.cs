using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Repository;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Factory;

namespace FinalProject_TokoBeDia.Handler
{
    public class PaymentTypeHandler
    {

        public static void InsertNewPaymentType(String name)
        {
            PaymentTypeRepository.InsertNewPaymentType(PaymentTypeFactory.CreateNewPaymentType(name));
        }

        public static List<PaymentType> GetAllPaymentTypeInfo()
        {
            return PaymentTypeRepository.GetAllPaymentTypeInfo();
        }

        public static List<PaymentType> GetPaymentTypeByName(String name)
        {
            return PaymentTypeRepository.GetPaymentTypeByName(name);
        }

        public static Boolean cekNama(String name)
        {
            return PaymentTypeRepository.cekNama(name);
        }

        public static void DeletePaymentType(String name)
        {
            PaymentTypeRepository.DeletePaymentType(name);
        }

        public static void UpdatePaymentType(String nameBefore, String nameAfter)
        {
            PaymentTypeRepository.UpdatePaymentType(nameBefore, nameAfter);
        }

        public static int getPaymentID(String name)
        {
            return PaymentTypeRepository.getPaymentID(name);
        }

    }
}