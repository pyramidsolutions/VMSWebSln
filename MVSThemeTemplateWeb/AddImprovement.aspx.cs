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
    public partial class AddImprovement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstServiceProvider();
            bindLstVehicles();
        }

        private void bindLstServiceProvider()
        {
            ManageServiceProvider manageServiceProvider = new ManageServiceProvider();

            var lstSPs = manageServiceProvider.getServiceProviderList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstServiceProvider.DataSource= lstSPs;
            lstServiceProvider.DataTextField = "SP_Name";
            lstServiceProvider.DataValueField = "SP_ID";
            lstServiceProvider.DataBind();

        }
        
        private void bindLstVehicles()
        { 
            ManageVehicle manageVehicle = new ManageVehicle();

            var lstVehicles = manageVehicle.getVehicleList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicle.DataSource = lstVehicles;
            lstVehicle.DataTextField = lstVehicles.Columns["Stock_Code"].ToString();
            lstVehicle.DataValueField = lstVehicles.Columns["Stock_Code"].ToString();
            lstVehicle.DataBind();
        }
        
        protected void btnSaveCustomer_ServerClick(object sender, EventArgs e)
        {
            ImprovementObject obj = new ImprovementObject();

            obj.SP_ID = Convert.ToInt32(lstServiceProvider.Value);
            obj.Improvement_Name = txtImprovementName.Value;
            obj.Stock_Code = int.Parse(lstVehicle.Value);
            obj.Improvement_Description = txtImprovementDescription.Value;
            obj.Improvement_price = decimal.Parse(txtImprovementPrice.Value);
            obj.Disable = chkBoxImprovementDisable.Checked;

            ManageImprovement manageImprovements = new ManageImprovement();

            bool success = manageImprovements.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }
        
    }
}