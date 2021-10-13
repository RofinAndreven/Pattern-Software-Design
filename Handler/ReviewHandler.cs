using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class ReviewHandler
    {

        public static List<Review> GetReviewListByUserId(int id)
        {
            return ReviewRepository.GetReviewsById(id);
        }
        public static bool InsertReview(int TransactDetailId, int rating, string desc)
        {
            Review newRv = ReviewFactory.Create(TransactDetailId, rating, desc);
            return ReviewRepository.InsertReview(newRv);
        }

        public static bool reviewupdate(int trnsactiondetailid ,int review, string desription)
        {
            Review r = ReviewRepository.GetShowreviewDetailById(trnsactiondetailid);
            if (r != null)
            {
                r.Rating = review;
                r.Description = desription;
                return ReviewRepository.UpdateShowReview(r);
            }
            else
            {
                return false;
            }
        }
        public static bool ReviewCancel(int userId)
        {
            List<Review> reviews = GetReviewListByUserId(userId);

            if (reviews.Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < reviews.Count; i++)
                {
                    ReviewRepository.RemoveThisUserReview(reviews[i]);
                }
                return true;
            }
        }
    }
}