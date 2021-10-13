using ProjectPSD.Controller;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        public int showTD;
        public Show show = new Show();
        public User user = new User();
        public Review review = new Review();
        public TransactionDetail td = new TransactionDetail();
        public Status st = new Status();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                User currUser = (User)Session["user"];
                showTD = Convert.ToInt32(Request.QueryString["ID"]);

                show = ShowController.GetShowById(showTD);
                user = UserController.GetUserById(show.Id);
                td = TransactionController.GetTransById(user.Id);

                lblName.Text += show.Name;
                lblSAR.Text += review.Rating;
                lblDesc.Text += show.Description;
                lblToken.Text += "";
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            int userId = ((User)Session["User"]).Id;

            string response = CartController.Cancel(userId);

            if (response == "")
            {
                lblError.Text = "";
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                lblError.Text = response;
            }
        }
    }
}