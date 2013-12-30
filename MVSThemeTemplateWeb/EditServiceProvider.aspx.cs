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
    public partial class EditServiceProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstSPCategories();
        }

  

        protected void grdServiceProvider_Load(object sender, EventArgs e)
        {
            ManageServiceProvider ServiceProviderObj = new ManageServiceProvider();
            grdServiceProvider.DataSource = ServiceProviderObj.getServiceProviders(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdServiceProvider.DataBind();
        }

        protected void grdServiceProvider_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);

            ManageServiceProvider ServiceProviderObj = new ManageServiceProvider();
            DataTable dt = ServiceProviderObj.getAServiceProvider(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtServiceProviderName.Value = DBUtility.readDBString(dr, "SP_Name");
                lstCategory.Value = DBUtility.readDBString(dr, "ServiceProviderCategory_Name");
                txtServiceProviderAddress.Value = DBUtility.readDBString(dr, "SP_address");
                txtServiceProviderTelephone.Value = DBUtility.readDBString(dr, "Telephone");

                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxModelDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }
        }

        protected void btnSaveServiceProvider_ServerClick(object sender, EventArgs e)
        {
            ServiceProviderObject obj = new ServiceProviderObject();

            obj.SP_Name = txtServiceProviderName.Value;
            obj.SP_address = txtServiceProviderAddress.Value;
            obj.Telephone = txtServiceProviderTelephone.Value;
            obj.Category = Convert.ToInt32(lstCategory.Items.FindByValue(lstCategory.Value).Value);
            obj.Disable = chkBoxModelDisable.Checked;

            ManageServiceProvider ServiceProviderObj = new ManageServiceProvider();

            bool success = ServiceProviderObj.updateAServiceProvider(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, obj, Convert.ToInt32(Session["rowIndex"]));



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;

            Session.Remove("rowIndex");
        }

        private void bindLstSPCategories()
        {
            ManageServiceProviderCategory manageSPCategory = new ManageServiceProviderCategory();

            var lstSPCategories = manageSPCategory.getServiceProviderCategoryList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstCategory.DataSource = lstSPCategories;
            lstCategory.DataTextField = "ServiceProviderCategory_Name";
            lstCategory.DataValueField = "ServiceProvider_Category_ID";
            lstCategory.DataBind();

        }
    }
}