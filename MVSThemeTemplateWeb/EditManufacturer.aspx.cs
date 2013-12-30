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
    public partial class EditManufacturer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void grdManufacturer_Load(object sender, EventArgs e)
        {
            ManageManufacturer manufacturerObj = new ManageManufacturer();
            grdManufacturer.DataSource = manufacturerObj.getManufacturerInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdManufacturer.DataBind();
        }

        protected void grdManufacturer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageManufacturer manufacturerObj = new ManageManufacturer();
            DataTable dt = manufacturerObj.getAManufacturer(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtManufacturerName.Value = DBUtility.readDBString(dr, "Manufacturer_Name");
            }
        }

        protected void btnSaveManufacturer_ServerClick(object sender, EventArgs e)
        {
            ManufacturerObject obj = new ManufacturerObject();

            obj.Manufacturer_Name = txtManufacturerName.Value;

            ManageManufacturer manufacturerObj = new ManageManufacturer();

            bool success = manufacturerObj.updateAManufacturer(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, obj, Convert.ToInt32(Session["rowIndex"]));



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;

            Session.Remove("rowIndex");
        }
    }
}