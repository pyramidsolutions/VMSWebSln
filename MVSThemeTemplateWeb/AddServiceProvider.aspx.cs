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
    public partial class AddServiceProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstSPCategories();
        }

        protected void btnSaveServiceProvider_ServerClick(object sender, EventArgs e)
        {
            ServiceProviderObject obj = new ServiceProviderObject();

            obj.SP_Name = txtServiceProviderName.Value;
            obj.SP_address= txtServiceProviderAddress.Value;
            obj.Telephone = txtServiceProviderTelephone.Value;
            obj.Category = Convert.ToInt32(lstCategory.Value);
            obj.Disable = chkBoxModelDisable.Checked;

            ManageServiceProvider ManageServiceProviderObj = new ManageServiceProvider();

            bool success = ManageServiceProviderObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
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