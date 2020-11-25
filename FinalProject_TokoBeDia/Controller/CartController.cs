using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Controller
{
    public class CartController
    {
        public static String validateCart(String email, int idProduk, int quantity)
        {
            String message = "";
            int sum = CartHandler.GetSum(idProduk);
            int stock = ProductHandler.GetStock(idProduk);
            Boolean cekCart = CartHandler.cekCart(email, idProduk);

            if (!quantity.GetType().FullName.Equals("System.Int32"))
            {
                message = "Quantity must be numeric";
            }
            else if (quantity <= 0)
            {
                message = "Quantity must be more than 0";
            }
            else if (quantity > stock)
            {
                message = "Quantity must be less than or equals to current stock ";
            }
            else if ((quantity+sum)>stock)
            {
                message = "The inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected product’s current stock";
            }
            else
            {
                if (cekCart)
                {
                    CartHandler.AddCart(email, idProduk, quantity);
                }
                else
                {
                    CartHandler.AddQuantity(email, idProduk, quantity);
                }

            }

            return message;
            
        }

        public static String validateUpdatedCart(String email, int idProduk, int quantity)
        {
            String message = "";
            int sum = CartHandler.GetSum(idProduk);
            int stock = ProductHandler.GetStock(idProduk);
            Boolean cekCart = CartHandler.cekCart(email, idProduk);

            if (!quantity.GetType().FullName.Equals("System.Int32"))
            {
                message = "Quantity must be numeric";
            }
            else if (quantity <= 0)
            {
                message = "Quantity must be more than 0";
            }
            else if (quantity > stock)
            {
                message = "Quantity must be less than or equals to current stock ";
            }
            else if ((quantity + sum) > stock)
            {
                message = "The inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected product’s current stock";
            }
            else
            {
                CartHandler.AddNewQuantity(email, idProduk, quantity); 
            }

            return message;

        }

    }
}