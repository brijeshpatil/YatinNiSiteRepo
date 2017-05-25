using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YatinNiSite.User
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                Session.Remove("UID");
            }
            else if (Session["UserProfile"] != null)
            {
                Session.Remove("UserProfile");
            }
            else if (Session["UName"] != null)
            {
                Session.Remove("UName");
            }
            else
            {
                Session.RemoveAll();
                Session.Abandon();
            }
            Response.Redirect("../LoginPage.aspx");

        }
    }
}