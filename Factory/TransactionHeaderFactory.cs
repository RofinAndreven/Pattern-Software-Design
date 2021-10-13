using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int BuyerId, int ShowId, DateTime showtime, DateTime createdat)
        {
            TransactionHeader th = new TransactionHeader();
            th.BuyerId = BuyerId;
            th.ShowId = ShowId;
            th.ShowTime = showtime;
            th.CreatedAt = createdat;
            return th;
        }
    }
}