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
    public partial class ReedemTokenPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReedem_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text;

            TransactionDetail td = TransactionController.GetToken(token);

            if(td.Token != token)
            {
                lblError.Text = "Invalid Token";
            }
            if(td.StatusId == 2)
            {
                Response.Redirect("ReviewPage.aspx");
            }
            else
            {
                Response.Redirect("ReviewPage.aspx?token=" +token);
            }
        }

        protected void btnNavigation_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }
    }
}