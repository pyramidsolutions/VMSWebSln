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
    public partial class ViewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void grdCustomer_Load(object sender, EventArgs e)
        {
            ManageCustomer customerObj = new ManageCustomer();
            grdCustomer.DataSource = customerObj.getCustomerInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdCustomer.DataBind();
        }

        protected void grdCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageCustomer custObj = new ManageCustomer();
            DataTable dt = custObj.getACustomer(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtCustomerName.Value = DBUtility.readDBString(dr, "Customer_name");
                txtCustomerAddress.Value = DBUtility.readDBString(dr, "Address_Line_1");
                txtCustomerAddressLine2.Value = DBUtility.readDBString(dr, "Address_Line_2");
                txtCustomerCity.Value = DBUtility.readDBString(dr, "City");
                txtCustomerCode.Value = DBUtility.readDBString(dr, "Code");
                txtCustomerTelephone.Value = DBUtility.readDBString(dr, "telephone_1");
                txtCustomerTelephone2.Value = DBUtility.readDBString(dr, "telephone_2");
                txtCustomerCellphone.Value = DBUtility.readDBString(dr, "Cellphone");
                txtCustomerFax.Value = DBUtility.readDBString(dr, "fax");
                txtCustomerEmail.Value = DBUtility.readDBString(dr, "email");
                txtCustomerRepresentative.Value = DBUtility.readDBString(dr, "Representative");
                txtCustomerVATNumber.Value = DBUtility.readDBString(dr, "VAT_Number");
                txtCustomerCKNumber.Value = DBUtility.readDBString(dr, "CK_number");
                if (dr["wholesale_customer"] != null && !dr.IsNull("wholesale_customer"))
                {
                    chkCustomerWholesaleCustomer.Checked = Convert.ToBoolean(dr["wholesale_customer"]);
                }
                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxCustomerDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }

        }
    }
}