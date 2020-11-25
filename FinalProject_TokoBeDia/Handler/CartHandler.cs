using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Factory;
using FinalProject_TokoBeDia.Repository;


namespace FinalProject_TokoBeDia.Handler
{
    public class CartHandler
    {
        public static void AddCart(String email, int idProduk, int quantity)
        {
            CartRepository.AddCart(CartFactory.AddCart(email, idProduk, quantity));
        }

        public static void DeleteAllCart(String email)
        {
            CartRepository.DeleteAllCart(email);
        }

        public static object GetCartDetailInfo(String email)
        {
            return CartRepository.GetCartDetailInfo(email);
        }

        public static int GetSum(int idProduk)
        {
            return CartRepository.GetSum(idProduk);
        }

        public static Boolean cekCart(String email, int idProduk)
        {
            return CartRepository.cekCart(email, idProduk);
        }

        public static void AddQuantity(String email, int idProduk, int quantity)
        {
            CartRepository.AddQuantity(email, idProduk, quantity);
        }

        public static void AddNewQuantity(String email, int idProduk, int quantity)
        {
            CartRepository.AddNewQuantity(email, idProduk, quantity);
        }

        public static object getCartByID(String email, int idProduk)
        {
            return CartRepository.getCartByID(email, idProduk);
        }

        public static void DeleteCart(String email, int idProduk)
        {
            CartRepository.DeleteCart(email, idProduk);
        }

        public static int GetQuantity(String email, int idProduk)
        {
            return CartRepository.GetQuantity(email, idProduk);
        }

        public static int GetGrandTotal(String email)
        {
            return CartRepository.GetGrandTotal(email);
        }
    }
}