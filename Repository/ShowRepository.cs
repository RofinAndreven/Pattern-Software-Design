using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class ShowRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();

        public static List<Show> GetAllShow()
        {
            return (from x in db.Shows select x).ToList();
        }

        public static Show GetShowDetailById(int id)
        {
            return (from x in db.Shows where x.Id == id select x).FirstOrDefault();

        }

        public static Show GetShowDetailByName(string name)
        {
            return (from x in db.Shows where x.Name == name select x).FirstOrDefault();
        }
        public static bool InsertShow(Show s)
        {
            if (s != null)
            {
                db.Shows.Add(s);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Show GetShowById(int id)
        {
            return db.Shows.Find(id);
        }

        public static Show getShowbyToken(string token)
        {
            Show show = (from shw in db.Shows join th in db.TransactionHeaders on shw.Id equals th.ShowId join td in db.TransactionDetails on th.Id equals td.TransactionHeaderId where td.Token == token select shw).FirstOrDefault();
        
            if(show != null)
            {
                return show;
            }
            return null;
        }

        public static bool UpdateShow(Show s)
        {
            if(s != null)
            {
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool insertReview(Review a)
        {
            if(a != null)
            {
                db.Reviews.Add(a);
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