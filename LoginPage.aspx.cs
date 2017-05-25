using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YatinNiSite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        PService PS = new PService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (PS.IsUser(txtuname.Text, txtpass.Text))
            {
                Session["UName"] = txtuname.Text;
                Session["UserProfile"] = PS.GetUserProfile(txtuname.Text);
                Session["UID"] = ((DataTable)Session["UserProfile"]).Rows[0]["UID"].ToString();
                Response.Redirect("User/Home.aspx");
            }
            else
            {
                lblError.Text = "Invalid UserName or Password.!!!";
            }
        }
    }
}