using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class TransactionHeaderHandler
    {
        public static TransactionHeader InsertTransactionHeader(int BuyerId, int ShowId, DateTime showtime, DateTime CreateAt)
        {
            TransactionHeader newTh = TransactionHeaderFactory.Create(BuyerId, ShowId, showtime, CreateAt);

            if (!TransactionHeaderRepository.InsertTransactHeader(newTh))
            {
                return null;
            }
            return newTh;
        }

        public static TransactionHeader GetTransactionHeaderById(int id)
        {
            return TransactionHeaderRepository.GetTransactionHeaderById(id);
        }
    }
}