using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Factory
{
    public class CartFactory
    {

        public static Cart AddCart(String email, int idProduk, int quantity)
        {
            Cart cart = new Cart();
            cart.ProductID = idProduk;
            cart.UserID = UserHandler.getUserID(email);
            cart.Quantity = quantity;

            return cart;
        }


    }
}