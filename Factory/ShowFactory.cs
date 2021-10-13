using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class ShowFactory
    {
        public static Show Create(string name, string url, string description, int price, int sellerid)
        {
            Show newShow = new Show();
            newShow.Name = name;
            newShow.URL = url;
            newShow.Description = description;
            newShow.Price = price;
            newShow.SellerId = sellerid;
            return newShow;
        }

        public static Review insertreview(int review, string description, int transactiondetail)
        {
            Review newReview = new Review();
            newReview.Rating = review;
            newReview.Description = description;
            newReview.TransactionDetailId = transactiondetail;
            return newReview;
        }
    }
}