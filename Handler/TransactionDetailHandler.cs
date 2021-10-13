using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class TransactionDetailHandler
    {
        public static bool InsertTransactionDetail(int TransactHeaderId, int statusId, string token)
        {
            TransactionDetail newTd = TransactionDetailFactory.Create(TransactHeaderId, statusId, token);
            return TransactionDetailRepository.InsertTransactDetail(newTd);
        }

        public static TransactionDetail GetTransById(int id)
        {
            return TransactionDetailRepository.GetTransById(id);
        }

        public static TransactionDetail GetTransactionByToken(string token)
        {
            return TransactionDetailRepository.GetToken(token);
        }

        public static bool UpdateTransactionDetail(int trnsactiondetailid)
        {
            TransactionDetail newTd = TransactionDetailRepository.GetTransById(trnsactiondetailid);
            if (newTd != null)
            {
                newTd.StatusId = 1;
                return TransactionDetailRepository.UpdateTransactionDetail(newTd);
            }
            else
            {
                return false;
            }
        }
    }
}