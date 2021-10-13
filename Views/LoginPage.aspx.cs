using ProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string response = UserController.CheckLogin(email, password);

            if(response == "")
            {
                Session["user"] = UserController.GetUser(email, password);
                Session["username"] = email;
                Session["password"] = password;
                Response.Redirect("NavigationPage.aspx");
            }
            else if (cbRemember.Checked)
            {
                Response.Cookies["email"].Expires = DateTime.Now.AddMinutes(30);
                Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(30);
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}