using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MVSThemeTemplateWeb
{
    public partial class AddModel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstVehicleType();
            bindLstManufacturer();
        }

        protected void btnSaveModel_ServerClick(object sender, EventArgs e)
        {
            ModelObject obj = new ModelObject();

            obj.Model_Name = txtModelName.Value;
            obj.Vehicle_Type = lstVehicleType.Value;
            obj.Manufacturer_Name = lstManufacturerName.Value;
            obj.Disable = chkBoxModelDisable.Checked;

            ManageModel modelObj = new ManageModel();

            bool success = modelObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
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