using ProjectPSD.Handler;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class CartRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();

        public static List<Cart> GetCartsById(int id)
        {
            return (from x in db.Carts where x.UserId == id select x).ToList();
        }

        public static Cart GetCartById(int id)
        {
            return db.Carts.Find(id);
        }

        public static Cart GetCartDetailById(int id)
        {
            return (from x in db.Carts where x.ShowId == id select x).FirstOrDefault();

        }

        public static bool Insert(Cart newCart)
        {
            if (newCart != null)
            {
                db.Carts.Add(newCart);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveThisUserCarts(Cart rmv)
        {
            if(rmv != null)
            {
                db.Carts.Remove(rmv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}