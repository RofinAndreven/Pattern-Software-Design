using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class ReviewRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();

        public static List<Review> GetReviewsById(int id)
        {
            return (from x in db.Reviews where x.TransactionDetailId == id select x).ToList();
        }

        public static Review GetShowreviewDetailById(int id)
        {
            return (from x in db.Reviews where x.TransactionDetailId == id select x).FirstOrDefault();

        }

        public static bool UpdateShowReview(Review s)
        {
            if (s != null)
            {
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InsertReview(Review newRv)
        {
            if (newRv != null)
            {
                db.Reviews.Add(newRv);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool RemoveThisUserReview(Review rmv)
        {
            if (rmv != null)
            {
                db.Reviews.Remove(rmv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}