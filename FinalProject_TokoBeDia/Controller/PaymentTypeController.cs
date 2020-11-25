using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Controller
{
    public class PaymentTypeController
    {

        public static String ValidateNewPaymentType(String name)
        {
            String message = "";
            Boolean cekNama = PaymentTypeHandler.cekNama(name);

            if (name.Equals(""))
            {
                message = "Payment Type Name must be filled";
            }
            else if (!cekNama)
            {
                message = "Payment must be unique";
            }
            else if (name.Length < 3)
            {
                message = "Payment consists of 3 characters or more";
            }
            else
            {
                PaymentTypeHandler.InsertNewPaymentType(name);
                message = "Payment Type successfully added to our database !";
            }

            return message;
        }

        public static String ValidateUpdatedPaymentType(String nameBefore, String nameAfter)
        {
            String message = "";
            Boolean cekNama = PaymentTypeHandler.cekNama(nameAfter);

            if (nameAfter.Equals(""))
            {
                message = "Payment Type Name must be filled";
            }
            else if (!cekNama)
            {
                message = "Payment must be unique";
            }
            else if (nameAfter.Length < 3)
            {
                message = "Payment consists of 3 characters or more";
            }
            else
            {
                PaymentTypeHandler.UpdatePaymentType(nameBefore, nameAfter);
                message = "Payment Type successfully updated to our database !";
            }

            return message;
        }

        public static String validatePaymentType(String email, String name)
        {
            String message = "";
            Boolean cekNama = PaymentTypeHandler.cekNama(name);

            if (cekNama)
            {
                message = "Payment Type not Available";
            }
            else
            {
                TransactionHandler.AddHeaderTransaction(email, name);
                TransactionHandler.AddNewTransaction(email);
                message = "Cart Successfully Added to transaction";
            }

            return message;
        }


    }
}