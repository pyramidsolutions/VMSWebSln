using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilityLibrary;

namespace MVSThemeTemplateWeb
{
    public partial class EditModel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstVehicleType();
            bindLstManufacturer();
            
        }

        protected void grdModel_Load(object sender, EventArgs e)
        {
            ManageModel ModelObj = new ManageModel();
            grdModel.DataSource = ModelObj.getModelInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdModel.DataBind();
        }

        protected void grdModel_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageModel ModelObj = new ManageModel();
            DataTable dt = ModelObj.getAModel(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtModelName.Value = DBUtility.readDBString(dr, "Model_Name");
                lstManufacturerName.Value = DBUtility.readDBString(dr, "Manufacturer_Name");
                lstVehicleType.Value = DBUtility.readDBString(dr, "VehicleType_Name");
                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxModelDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }
        }

        protected void btnSaveModel_ServerClick(object sender, EventArgs e)
        {
            ModelObject obj = new ModelObject();

            obj.Manufacturer_Name = lstManufacturerName.Value;
            obj.Model_Name = txtModelName.Value;
            obj.Vehicle_Type = lstVehicleType.Value;
            obj.Disable = chkBoxModelDisable.Checked;

            ManageModel ModelObj = new ManageModel();

            bool success = ModelObj.updateAModel(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, obj, Convert.ToInt32(Session["rowIndex"]));



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;

            Session.Remove("rowIndex");
        }

        private void bindLstVehicleType()
        {
            ManageVehicleType manageVehicleTypeObj = new ManageVehicleType();

            var lstSPs = manageVehicleTypeObj.getVehicleTypeList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicleType.DataSource = lstSPs;
            lstVehicleType.DataTextField = "VehicleType_Name";
            lstVehicleType.DataValueField = "VehicleType_Name";
            lstVehicleType.DataBind();

        }

        private void bindLstManufacturer()
        {
            ManageManufacturer manageManufacturer = new ManageManufacturer();

            var lstManufacturer = manageManufacturer.getManufacturerList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstManufacturerName.DataSource = lstManufacturer;
            lstManufacturerName.DataTextField = "Manufacturer_Name";
            lstManufacturerName.DataValueField = "Manufacturer_Name";
            lstManufacturerName.DataBind();
        }
    }
}