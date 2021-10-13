using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class UserRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();

        public static bool InsertUser(User u)
        {
            if (u != null)
            {
                db.Users.Add(u);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static User GetUser(string email, string password)
        {
            return (from x in db.Users where x.Username == email && x.Password == password select x).FirstOrDefault();
        }

        public static User GetUserById(int id)
        {
            return (from x in db.Users where x.Id == id select x).FirstOrDefault();
        }

        public static User GetUserbyemail(string email)
        {
            return db.Users.Find(email);
        }

        public static bool updateuser(User u)
        {
            if (u != null)
            {
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}