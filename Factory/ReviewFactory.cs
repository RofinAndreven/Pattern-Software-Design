using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class ReviewFactory
    {
        public static Review Create(int TransactDetailId, int rating, string desc)
        {
            Review newRv = new Review();
            newRv.TransactionDetailId = TransactDetailId;
            newRv.Rating = rating;
            newRv.Description = desc;
            return newRv;
        }
    }
}