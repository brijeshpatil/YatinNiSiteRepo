using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YatinNiSite.Admin
{
    public partial class ManageLocation : System.Web.UI.Page
    {
        PService PS = new PService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridState();
                FillGridCity();
                fillstate();
            }
        }

        private void FillGridCity()
        {
            GridCity.DataSource = PS.GetCitiesWithStates();
            GridCity.DataBind();
        }
        public void fillstate()
        {
            drpState.DataSource = PS.GetAllStates();
            drpState.DataTextField = "StateName";
            drpState.DataValueField = "StateID";
            drpState.DataBind();
        }

        private void FillGridState()
        {
            GridView1.DataSource = PS.GetAllStates();
            GridView1.DataBind();
        }
        protected void btnState_Click(object sender, EventArgs e)
        {
            if (PS.AddNewState(txtSName.Text))
            {
                lblStatus.Text = "Record Saved.!!!";
            }
            else
            {
                lblStatus.Text = "There should be error.!! Please Try again after some time!!!";
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGridState();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillGridState();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PS.StateID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            PS.StateName = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            PS.UpdateState(PS);
            GridView1.EditIndex = -1;
            FillGridState();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PS.StateID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            PS.DeleteState(PS.StateID);
            FillGridState();
        }
        protected void btnCity_Click(object sender, EventArgs e)
        {
            int StateID = Convert.ToInt16(drpState.SelectedItem.Value);
            string CityName = txtCName.Text;
            PS.AddNewCity(StateID, CityName);
            FillGridCity();
        }
        protected void GridCity_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblState = (Label)GridCity.Rows[e.NewEditIndex].FindControl("Label4");

            GridCity.EditIndex = e.NewEditIndex;
            FillGridCity();

            DropDownList drpStateGRID = (DropDownList)GridCity.Rows[e.NewEditIndex].FindControl("DropDownList1");
            drpStateGRID.DataSource = PS.GetAllStates();
            drpStateGRID.DataTextField = "StateName";
            drpStateGRID.DataValueField = "StateID";
            drpStateGRID.DataBind();

            foreach (ListItem li in drpStateGRID.Items)
            {
                if (li.Text == lblState.Text)
                {
                    li.Selected = true;
                }
            }
        }
        protected void GridCity_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridCity.EditIndex = -1;
            FillGridCity();
        }
        protected void GridCity_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PS.CityID = Convert.ToInt16(GridCity.DataKeys[e.RowIndex].Value);
            PS.DeleteCity(PS.CityID);
            FillGridCity();
        }
        protected void GridCity_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PS.CityID = Convert.ToInt16(GridCity.DataKeys[e.RowIndex].Value);
            PS.CityName = ((TextBox)GridCity.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            PS.StateID = Convert.ToInt16(((DropDownList)GridCity.Rows[e.RowIndex].FindControl("DropDownList1")).SelectedItem.Value);
            PS.UpdateCity(PS);
            GridCity.EditIndex = -1;
            FillGridCity();
        }
    }
}