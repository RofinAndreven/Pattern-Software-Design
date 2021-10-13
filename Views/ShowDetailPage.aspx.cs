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
    public partial class ShowDetailPage : System.Web.UI.Page
    {
        public int showID;
        Show show = new Show();
        User user = new User();
        Review review = new Review();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                User currUser = (User)Session["user"];
                showID = Convert.ToInt32(Request.QueryString["ID"]);

                show = ShowController.GetShowById(showID);
                user = UserController.GetUserById(show.Id);

                lblShowName.Text += show.Name;
                lblPrice.Text += show.Price.ToString();
                lblSellerName.Text += user.Name;
                lblDescription.Text += show.Description;
                lblReviewRating.Text += review.Rating;
                lblReviewDesc.Text += review.Description;
                
                if(currUser.RoleId == 1)
                {
                    btnUpdate.Visible = true;
                    btnOrder.Visible = false;
                }
                if(currUser.RoleId == 2)
                {
                    btnOrder.Visible = true;
                    btnUpdate.Visible = false;
                }
                
            }
           
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateShowPage.aspx");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderPage.aspx?ID=" + showID);
        }
    }
}