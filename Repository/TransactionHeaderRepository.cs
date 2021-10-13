using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class TransactionHeaderRepository
    {
        private static DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();
        public static bool InsertTransactHeader(TransactionHeader newTh)
        {
            if (newTh != null)
            {
                db.TransactionHeaders.Add(newTh);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<TransactionHeader> GetTransactions()
        {
            return db.TransactionHeaders.ToList();
        }

        public static TransactionHeader GetTransactionHeaderById(int id)
        {
            return (from x in db.TransactionHeaders where x.Id == id select x).FirstOrDefault();
        }
    }
}