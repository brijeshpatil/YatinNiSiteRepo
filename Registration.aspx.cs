using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YatinNiSite
{
    public partial class Registration : System.Web.UI.Page
    {
        PService PS = new PService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillStates();
            }
        }

        private void FillStates()
        {
            drpState.DataSource = PS.GetAllStates();
            drpState.DataTextField = "StateName";
            drpState.DataValueField = "StateID";
            drpState.DataBind();

            FillCities(Convert.ToInt16(drpState.SelectedItem.Value));
        }

        private void FillCities(int StateID)
        {
            drpCity.DataSource = PS.GetCityByState(StateID);
            drpCity.DataTextField = "CityName";
            drpCity.DataValueField = "CityID";
            drpCity.DataBind();
        }
        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateID = Convert.ToInt16(drpState.SelectedItem.Value);
            FillCities(StateID);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            PS.FirstName = txtfname.Text;
            PS.LastName = txtlname.Text;
            PS.Gender = RadioButtonList1.SelectedItem.Text;
            PS.StateID = Convert.ToInt16(drpState.SelectedItem.Value);
            PS.CityID = Convert.ToInt16(drpCity.SelectedItem.Value);
            PS.UserName = txtUname.Text;
            PS.Password = txtpass.Text;
            PS.RegNewUser(PS);
            Response.Redirect("LoginPage.aspx");
        }
    }
}