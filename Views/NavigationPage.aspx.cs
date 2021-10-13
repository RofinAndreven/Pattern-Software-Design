using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class NavigationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                User currUser = (User)Session["user"];
                lblWelcome.Text = "Guest";
                btnHome.Visible = true;
                btnLogin.Visible = true;
                btnRegister.Visible = true;
                btnRedeem.Visible = true;
            }
            else
            {
                User currUser = (User)Session["user"];
                if(currUser.RoleId == 1)
                {
                    lblWelcome.Text = "Seller";
                    btnHome.Visible = true;
                    btnAddShow.Visible = true;
                    btnReports.Visible = true;
                    btnAcc.Visible = true;
                    btnRedeem.Visible = true;
                    btnLogout.Visible = true;
                }
                else if(currUser.RoleId == 2)
                {
                    lblWelcome.Text = "Buyer";
                    btnHome.Visible = true;
                    btnAcc.Visible = true;
                    btnRedeem.Visible = true;
                    btnLogout.Visible = true;
                    btnTransact.Visible = true;
                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void btnTransact_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionPage.aspx");
        }

        protected void btnAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("NavigationPage.aspx");
        }

        protected void btnRedeem_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReedemTokenPage.aspx");
        }

        protected void btnReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportPage.aspx");
        }

        protected void btnAddShow_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddShowPage.aspx");
        }

    }
}