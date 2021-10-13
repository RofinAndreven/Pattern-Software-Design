using ProjectPSD.Handler;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class ReviewController
    {
        public static string CheckInsertReview(int transactdetailId, string rating , string desc)
        {
            string response = "";

            if(response == "")
            {
                if (rating == "")
                {
                    response = "Rating must be filled";
                }
                else if (desc == "")
                {
                    response = "Desc must be filled!";
                }
                else
                {
                    int rate = int.Parse(rating);
                    if (rate < 1 || rate > 5)
                    {
                        response = "Rating must be at least 1 and at most 5";
                    }
                    else
                    {
                        if (ReviewHandler.InsertReview(transactdetailId, rate, desc))
                        {
                            response = "";
                        }
                        else
                        {
                            response = "Failed to Insert Review!";
                        }
                    }
                }
            }
            return response;
        }

        public static string reviewupdatecheck(int transactiondetailId ,string review, string description)
        {
            string response = "";
            int parsedvalude;

            if (response == "")
            {
                if (review == "")
                {
                    response = "Review cannot be empty";
                }
                else if (!int.TryParse(review, out parsedvalude))
                {
                    response = "Review must be numerical";
                }
                else if (description == "")
                {
                    response = "Description cannot be empty";
                }
                else
                {
                    if (int.TryParse(review, out parsedvalude))
                    {
                        if (ReviewHandler.reviewupdate(transactiondetailId, parsedvalude, description))
                        {
                            TransactionDetailHandler.UpdateTransactionDetail(transactiondetailId);
                            response = "";
                        }
                        else
                        {
                            response = "Failed to update review!";
                        }
                    }
                }
            }
            return response;
        }

        public static string ReviewCancel(int transactdetailid)
        {
            string response = "";
            if (ReviewHandler.ReviewCancel(transactdetailid))
            {
                response = "";
            }
            else
            {
                response = "You dont have review!";
            }
            return response;
        }
    }
}