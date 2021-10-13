using ProjectPSD.DataSets;
using ProjectPSD.Model;
using ProjectPSD.Reports;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionsReport tr = new TransactionsReport();
            crvTransactions.ReportSource = tr;
            tr.SetDataSource(GetData());
        }

        protected DataSetProjectPSD GetData()
        {
            List<TransactionHeader> headers = TransactionHeaderRepository.GetTransactions();
            DataSetProjectPSD ds = new DataSetProjectPSD();
            var ds_header = ds.TransactionHeader;
            var ds_detail = ds.TransactionDetail;

            foreach(var header in headers)
            {
                var newRow = ds_header.NewRow();
                newRow["Id"] = header.Id;
                newRow["BuyerId"] = header.BuyerId;
                newRow["Username"] = UserRepository.GetUserById(header.BuyerId).Username;
                newRow["ShowTime"] = header.ShowTime;
                newRow["CreatedAt"] = header.CreatedAt;
                ds_header.Rows.Add(newRow);

                List<TransactionDetail> details = TransactionDetailRepository.GetTransactionDetails(header.Id);
                foreach(var detail in details)
                {
                    var newDetail = ds_detail.NewRow();
                    newDetail["TransactionId"] = detail.TransactionHeaderId;
                    newDetail["ShowId"] = ShowRepository.GetShowDetailById(header.ShowId).Id;
                    newDetail["ShowName"] = ShowRepository.GetShowDetailById(header.ShowId).Name;
                    newDetail["Price"] = ShowRepository.GetShowDetailById(header.ShowId).Price;
                    newDetail["Quantity"] = CartRepository.GetCartDetailById(header.BuyerId).Quantity;
                    ds_detail.Rows.Add(newDetail);

                }
            }
            return ds;
        }

        protected void btnNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }
    }
}