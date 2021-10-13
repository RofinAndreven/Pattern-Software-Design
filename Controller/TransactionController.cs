using ProjectPSD.Handler;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class TransactionController
    {

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string InsertTransaction(int buyerId, int showId, DateTime showtime, DateTime createdat, int qty)
        {
            if(qty <= 0)
            {
               return "Quantity must be at least 1";
            }
            else
            {
                TransactionHeader newTh = TransactionHeaderHandler.InsertTransactionHeader(buyerId, showId, showtime, createdat);
                
                int statusId = 2;
                int transactHeadId = newTh.Id;

                for(int i = 0; i < qty; i++)
                {
                    string token = RandomString(6);
                    TransactionDetailHandler.InsertTransactionDetail(transactHeadId, statusId, token);
                }
                return "Order Success!";
            }
        }
        public static TransactionDetail GetTransById(int id)
        {
            return TransactionDetailHandler.GetTransById(id);
        }
        public static TransactionHeader GetTransactionHeaderById(int id)
        {
            return TransactionHeaderHandler.GetTransactionHeaderById(id);
        }

        public static TransactionDetail GetToken(string token)
        {
            return TransactionDetailHandler.GetTransactionByToken(token);
        }
    }
}