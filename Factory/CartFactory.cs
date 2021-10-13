using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class CartFactory
    {
        public static Cart Create(int userId, int showId, int qty, DateTime selected, int totalprice)
        {
            Cart newCart = new Cart();
            newCart.UserId = userId;
            newCart.ShowId = showId;
            newCart.Quantity = qty;
            newCart.Time = selected;
            newCart.TotalPrice = totalprice;
            return newCart;
        }
    }
}