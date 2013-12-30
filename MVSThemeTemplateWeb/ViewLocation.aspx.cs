﻿using MVS_BLL.CustomDataObjects;
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
    public partial class ViewLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdLocation_Load(object sender, EventArgs e)
        {
            ManageLocation locationObj = new ManageLocation();
            grdLocation.DataSource = locationObj.getLocationInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdLocation.DataBind();
        }

        protected void grdLocation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageLocation locationObj = new ManageLocation();
            DataTable dt = locationObj.getALocation(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtLocationName.Value = DBUtility.readDBString(dr, "Location_Name");
                txtLocationDescription.Value = DBUtility.readDBString(dr, "Location_Description");
                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxLocationDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }

        }
    }
}