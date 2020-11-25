using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Factory
{
    public class PaymentTypeFactory
    {
  
        public static PaymentType CreateNewPaymentType(String name)
        {
            PaymentType paymentType = new PaymentType();
            paymentType.PaymentTypeName = name;

            return paymentType;
        }

    }
}