using ProjectPSD.Factory;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class InsertShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string url = txturl.Text;
            string description = txtDescription.Text;
            string price = txtPrice.Text;
            int sellerid = 1;


            //get id sller (WIP)
            //User curruser = (User)

            if (name == "")
            {
                lblError.Text = "Name must be filled";
            }
            else if (url == "")
            {
                lblError.Text = "URL must be filled";
            }
            else if (price == "")
            {
                lblError.Text = "Price cannot be empty";
            }

            else if (int.TryParse(price, out int value))
            {
                lblError.Text = "Price must be an integer";
            }
            else if (int.Parse(price) < 1000)
            {
                lblError.Text = "Price must be more than 1000";
            }
            else if(description == "")
            {
                lblError.Text = "Description must be filled";
            }
            else
            {
                Show newShow = ProductFactory.Create(name, url, description, int.Parse(price), sellerid);
                DatabaseProjectPSDEntities db = new DatabaseProjectPSDEntities();
                db.Shows.Add(newShow);
                db.SaveChanges();


                Response.Redirect("HomePage.aspx");
            }           


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}