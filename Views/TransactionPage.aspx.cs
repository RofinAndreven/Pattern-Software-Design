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
    public partial class TransactionPage : System.Web.UI.Page
    {
        protected void FillGrid()
        {
            User currUser = (User)Session["user"];
            gvTransaction.DataSource = CartController.GetCartListByUserId(currUser.Id);
            gvTransaction.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                User currUser = (User)Session["user"];
                if(currUser.RoleId != 2)
                {
                    Response.Redirect("NavigationPage.aspx");
                }
                else
                {
                    FillGrid();
                }
            }
        }

        protected void gvTransaction_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow gvr = gvTransaction.Rows[e.NewEditIndex];
            string showTD = gvr.Cells[0].Text.ToString();
            Response.Redirect("TransactionDetailPage.aspx?ID=" + showTD);
        }
    }
}