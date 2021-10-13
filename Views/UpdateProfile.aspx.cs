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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User currUser = (User)Session["user"];
            string name = txtName.Text;
            string oldpassword = txtOldPassword.Text;
            string newpassword = txtNewPassword.Text;
            string confirmpassword = txtConfirmNew.Text;
            string password = currUser.Password;
            string email = currUser.Username;

            string response = UserController.Checkupdate(name, oldpassword, newpassword, confirmpassword, password, email);
            
            if(response == "")
            {
                lblError.Text = "";
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