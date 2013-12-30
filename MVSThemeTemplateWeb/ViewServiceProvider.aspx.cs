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
    public partial class ViewServiceProvider : System.Web.UI.Page
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
            
        }

        protected void btnSaveServiceProvider_ServerClick(object sender, EventArgs e)
        {
           
        }

        private void bindLstSPCategories()
        {
            
        }
    }
}