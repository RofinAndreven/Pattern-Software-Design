using ProjectPSD.Repository;
using ProjectPSD.Model;
using ProjectPSD.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPSD.Controller;

namespace ProjectPSD.Views
{
    public partial class OrderPage : System.Web.UI.Page
    {
        public int showID;
        public int totalprice;

        protected void FillGrid()
        {
            User currUser = (User)Session["user"];
            gvCarts.DataSource = CartController.GetCartListByUserId(currUser.Id);
            gvCarts.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("NavigationPage.aspx");
            }
            else
            {
                User currUser = (User)Session["user"];
                if (currUser.RoleId != 2)
                {
                    Response.Redirect("NavigationPage.aspx");
                }
                else
                {
                    showID = Convert.ToInt32(Request.QueryString["ID"]);
                    Show a = ShowController.GetShowById(showID);
                    lblMovie.Text = a.Name;
                    FillGrid();
                }
            }
        }
        protected void btnOrder1_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("00:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError1.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError1.Text = response;
                }
            }
        }

        protected void btnOrder2_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("01:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError2.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError2.Text = response;
                }
            }
        }

        protected void btnOrder3_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("02:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError3.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError3.Text = response;
                }
            }
        }

        protected void btnOrder4_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("03:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError4.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError4.Text = response;
                }
            }
        }

        protected void btnOrder5_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("04:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError5.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError5.Text = response;
                }
            }
        }

        protected void btnOrder6_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("05:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError6.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError6.Text = response;
                }
            }
        }

        protected void btnOrder7_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("06:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError7.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError7.Text = response;
                }
            }
        }

        protected void btnOrder8_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("07:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError8.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError8.Text = response;
                }
            }
        }

        protected void btnOrder9_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("08:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError9.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError9.Text = response;
                }
            }
        }

        protected void btnOrder10_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("09:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError10.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError10.Text = response;
                }
            }
        }

        protected void btnOrder11_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("10:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError11.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError11.Text = response;
                }
            }
        }

        protected void btnOrder12_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("11:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError12.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError12.Text = response;
                }
            }
        }

        protected void btnOrder13_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("12:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError13.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError13.Text = response;
                }
            }
        }

        protected void btnOrder14_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("13:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError14.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError14.Text = response;
                }
            }
        }

        protected void btnOrder15_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("14:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError15.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError15.Text = response;
                }
            }
        }

        protected void btnOrder16_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("15:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError16.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError16.Text = response;
                }
            }
        }

        protected void btnOrder17_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("16:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError17.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError17.Text = response;
                }
            }
        }

        protected void btnOrder18_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("17:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError18.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError18.Text = response;
                }
            }
        }

        protected void btnOrder19_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("18:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError19.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError19.Text = response;
                }
            }
        }

        protected void btnOrder20_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("19:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError20.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError20.Text = response;
                }
            }
        }

        protected void btnOrder21_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("20:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError21.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError21.Text = response;
                }
            }
        }

        protected void btnOrder22_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("21:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError22.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError22.Text = response;
                }
            }
        }

        protected void btnOrder23_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("22:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError23.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError23.Text = response;
                }
            }
        }

        protected void btnOrder24_Click(object sender, EventArgs e)
        {
            DateTime show = DateTime.Parse("23:00:00");
            if (Convert.ToDateTime(show).Subtract(DateTime.Now).TotalHours <= 1)
            {
                LblError24.Text = "Unavailable";
            }
            else
            {
                string s_qty = txtQty.Text;
                int userId = ((User)Session["User"]).Id;
                User h = UserRepository.GetUserById(userId);
                Show s = ShowRepository.GetShowById(showID);
                int id = h.Id;
                int totalprice = s.Price * int.Parse(s_qty);
                string response = CartController.CheckInsertCart(id, showID, s_qty, show, totalprice);
                TransactionController.InsertTransaction(userId, showID, show, DateTime.Now, int.Parse(s_qty));
                if (response == "")
                {
                    FillGrid();
                }
                else
                {
                    LblError24.Text = response;
                }
            }
        }

        protected void btnNavigation_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }
    }
}