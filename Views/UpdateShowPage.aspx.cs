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
    public partial class UpdateShowPage : System.Web.UI.Page
    {
        int sellerTest;

        protected void FillGrid()
        {
            gvShow.DataSource = ShowController.GetShowList();
            gvShow.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            User currUser = (User)Session["user"];
            if (currUser.RoleId != 1)
            {
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                sellerTest = currUser.Id;
                FillGrid();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string url = txturl.Text;
            string description = txtDescription.Text;
            int price = int.Parse(txtPrice.Text);
            int sellerid = sellerTest;

            string response = ShowController.CheckUpdate(id, name, url, description, price, sellerid);

            if (response == "")
            {
                lblError.Text = "";
                FillGrid();
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }
    }
}