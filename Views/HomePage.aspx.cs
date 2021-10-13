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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void FillGrid()
        
        {
            gvShowDetail.DataSource = ShowController.GetShowList();
            gvShowDetail.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("NavigationPage.aspx");
        }

        protected void gvShowDetail_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow gvr = gvShowDetail.Rows[e.NewEditIndex];
            string showID = gvr.Cells[0].Text.ToString();
            Response.Redirect("ShowDetailPage.aspx?ID=" + showID);
        }

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string name = txtSearch.Text;
        //    Show show = ShowController.GetShowListByName(name);

        //    if (show != null)
        //    {
        //        gvShowDetailBySearch.ID = show.Id;
                
        //        gvShowDetail.Visible = false;
        //    }
        //    else
        //    {
        //        lblError.Text = "Show Not Found!";
        //    }

        //}

        //protected void gvShowDetailBySearch_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GridViewRow gvr = gvShowDetail.Rows[e.NewEditIndex];
        //    string showID = gvr.Cells[0].Text.ToString();
        //    Response.Redirect("ShowDetailPage.aspx?ID=" + showID);
        //}
    }
}