using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int TransactHeaderId, int statusId, string token)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionHeaderId = TransactHeaderId;
            td.StatusId = statusId;
            td.Token = token;
            return td;
        }
    }
}