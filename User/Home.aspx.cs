using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YatinNiSite.User
{
    public partial class Home : System.Web.UI.Page
    {
        PService PS = new PService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)
            {
                Response.Redirect("../LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                FillPosts();
            }
        }

        private void FillPosts()
        {
            DataList1.DataSource = PS.GetAllPosts();
            DataList1.DataBind();
        }
        protected void btnPost_Click(object sender, EventArgs e)
        {
            PS.UserID = Convert.ToInt16(Session["UID"].ToString());
            PS.PostData = txtPostData.Text;
            PS.AddNewPost(PS);
            FillPosts();
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Like")
            {
                PS.LikePost(Convert.ToInt16(Session["UID"].ToString()), Convert.ToInt16(e.CommandArgument.ToString()));
                FillPosts();
            }
            if (e.CommandName == "UnLike")
            {
                PS.UnLikePost(Convert.ToInt16(Session["UID"].ToString()), Convert.ToInt16(e.CommandArgument.ToString()));
                FillPosts();
            }
            if (e.CommandName == "PostComment")
            {
                PS.CommentData = ((TextBox)e.Item.FindControl("txtCommentData")).Text;
                PS.PostID = Convert.ToInt16(e.CommandArgument.ToString());
                PS.UserID = Convert.ToInt16(Session["UID"].ToString());
                PS.PostComment(PS);
                Panel pnl = (Panel)e.Item.FindControl("Panel1");
                pnl.Visible = false;
                FillPosts();
            }

            if (e.CommandName == "Comment")
            {
                Panel pnl = (Panel)e.Item.FindControl("Panel1");
                pnl.Visible = true;
            }
        }
        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            LinkButton lnkLike = (LinkButton)e.Item.FindControl("lnkLike");
            int PostID = Convert.ToInt16(lnkLike.CommandArgument.ToString());
            int UserID = Convert.ToInt16(Session["UID"].ToString());
            if (PS.IsLiked(UserID, PostID))
            {
                lnkLike.Text = "UnLike";
                lnkLike.CommandName = "UnLike";
            }
            else
            {
                lnkLike.Text = "Like";
                lnkLike.CommandName = "Like";
            }

            DataList ddlComment = (DataList)e.Item.FindControl("DataList2");
            ddlComment.DataSource = PS.GetCommentsByPost(PostID);
            ddlComment.DataBind();
        }
    }
}