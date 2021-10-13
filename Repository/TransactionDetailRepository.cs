using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class TransactionDetailRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();

        public static bool InsertTransactDetail(TransactionDetail newTd)
        {
            if(newTd != null)
            {
                db.TransactionDetails.Add(newTd);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool UpdateTransactionDetail(TransactionDetail newTd)
        {
            if (newTd != null)
            {
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<TransactionDetail> GetTransactionDetails(int TransactionHeaderId)
        {
            return (from x in db.TransactionDetails where x.TransactionHeaderId == TransactionHeaderId select x).ToList();
        }

        public static TransactionDetail GetToken(string token)
        {
            return (from x in db.TransactionDetails where x.Token == token select x).FirstOrDefault();
        }

        public static TransactionDetail GetTransById(int id)
        {
            return (from x in db.TransactionDetails where x.Id == id select x).FirstOrDefault();
        }

    }
}