using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class CartHandler
    {
        public static List<Cart> GetCartListByUserId(int id)
        {
            return CartRepository.GetCartsById(id);
        }

        public static bool InsertCart(int userId, int showId, int qty, DateTime selected, int totalprice)
        {
            User u = UserRepository.GetUserById(userId);
            Show s = ShowRepository.GetShowById(showId);
            if(u != null && s != null)
            {
                Cart newCart = CartFactory.Create(userId, showId, qty, selected, totalprice);
                return CartRepository.Insert(newCart);
            }
            return false;
        }

        public static bool Cancel(int userId)
        {
            List<Cart> carts = GetCartListByUserId(userId);

            if(carts.Count == 0)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < carts.Count; i++)
                {
                    CartRepository.RemoveThisUserCarts(carts[i]);
                }
                return true;
            }
        }
    }
}