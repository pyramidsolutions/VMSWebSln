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
    public partial class AddLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveLocation_ServerClick(object sender, EventArgs e)
        {
            LocationObject obj = new LocationObject();

            obj.Location_Name = txtLocationName.Value;
            obj.Location_Description = txtLocationDescription.Value;
            obj.Disable = chkBoxLocationDisable.Checked;

            ManageLocation manageLocations = new ManageLocation();

            bool success = manageLocations.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }
    }
}