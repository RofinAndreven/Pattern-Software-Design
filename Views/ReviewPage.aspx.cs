using ProjectPSD.Controller;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class ReviewPage : System.Web.UI.Page
    {
        TransactionDetail td = new TransactionDetail();
        TransactionHeader th = new TransactionHeader();
        Show show = new Show();
        User user = new User();
        public string token;

        protected void Page_Load(object sender, EventArgs e)
        {

                token = Request.QueryString["token"];
                show = ShowController.GetShowByToken(token);
                user = UserController.GetUserById(show.SellerId);

                lblMovie.Text += show.Name;
                lblSeller.Text += user.Name;
                lblDescription.Text += show.Description;

                Review r = ReviewRepository.GetShowreviewDetailById(show.Id);

            if (r != null)
            {
                btnUpdate.Visible = true;
                btnRemove.Visible = true;
            }
            else
            {
                btnRate.Visible = true;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string rating = txtRating.Text;
            string description = txtDescription.Text;

            string response = ReviewController.reviewupdatecheck(td.Id, rating, description);
        }

        protected void btnRate_Click(object sender, EventArgs e)
        {
            string rating = txtRating.Text;
            string description = txtDescription.Text;

            string response = ReviewController.CheckInsertReview(td.Id, rating, description);
            if (response == "")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            string response = ReviewController.ReviewCancel(td.Id);
            if (response == "")
            {
                response = "";
            }
            else
            {
                lblError.Text = response;
            }

        }

        protected void btnNavigation_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }
    }
}