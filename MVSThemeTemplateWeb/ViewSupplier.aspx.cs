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
    public partial class ViewSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdSupplier_Load(object sender, EventArgs e)
        {
            ManageSupplier supplierObj = new ManageSupplier();
            grdSupplier.DataSource = supplierObj.getSupplierInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdSupplier.DataBind();
        }

        protected void grdSupplier_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageSupplier supplierObj = new ManageSupplier();
            DataTable dt = supplierObj.getASupplier(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtSupplierName.Value = DBUtility.readDBString(dr, "Supplier_name");
                txtSupplierAddress.Value = DBUtility.readDBString(dr, "Address_Line_1");
                txtSupplierAddressLine2.Value = DBUtility.readDBString(dr, "Address_Line_2");
                txtSupplierCity.Value = DBUtility.readDBString(dr, "City");
                txtSupplierCode.Value = DBUtility.readDBString(dr, "Code");
                txtSupplierTelephone.Value = DBUtility.readDBString(dr, "telephone_1");
                txtSupplierTelephone2.Value = DBUtility.readDBString(dr, "telephone_2");
                txtSupplierCellphone.Value = DBUtility.readDBString(dr, "Cellphone");
                txtSupplierFax.Value = DBUtility.readDBString(dr, "fax");
                txtSupplierEmail.Value = DBUtility.readDBString(dr, "email");
                txtSupplierRepresentative.Value = DBUtility.readDBString(dr, "Representative");
                txtSupplierVATNumber.Value = DBUtility.readDBString(dr, "VAT_number");
                txtSupplierCKNumber.Value = DBUtility.readDBString(dr, "CK_number");
                if (dr["wholesale_supplier"] != null && !dr.IsNull("wholesale_supplier"))
                {
                    chkSupplierWholesale.Checked = Convert.ToBoolean(dr["wholesale_supplier"]);
                }
                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxSupplierDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }

        }

    }
}