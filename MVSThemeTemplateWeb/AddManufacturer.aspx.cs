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
    public partial class AddManufacturer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveManufacturer_ServerClick(object sender, EventArgs e)
        {
            ManufacturerObject obj = new ManufacturerObject();

            obj.Manufacturer_Name = txtManufacturerName.Value;
           
            ManageManufacturer manufacturerObj = new ManageManufacturer();

            bool success = manufacturerObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }
    }
}