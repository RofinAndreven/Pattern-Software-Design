using ProjectPSD.Handler;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class CartController
    {
        public static List<Cart> GetCartListByUserId(int id)
        {
            return CartHandler.GetCartListByUserId(id);
        }

        public static string CheckInsertCart(int userId, int showid, string s_qty, DateTime selected, int TotalPrice)
        {
            string response = "";

            if(s_qty == "")
            {
                response = "Quantity must be filled";
            }
            else
            {
                int qty = int.Parse(s_qty);

                if(qty < 1)
                {
                    response = "Quantity must be at least 1";
                }
                else
                {
                    if(CartHandler.InsertCart(userId, showid, qty, selected, TotalPrice))
                    {
                        response = "Insert Success";
                    }
                    else
                    {
                        response = "Failed to place order!";
                    }
                }
            }
            return response;
        }

        public static string Cancel(int userId)
        {
            string response = "";
            if (CartHandler.Cancel(userId))
            {
                response = "";
            }
            else
            {
                response = "You dont have order!";
            }
            return response;
        }
    }
}