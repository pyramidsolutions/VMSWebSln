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
    public partial class AddSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveSupplier_ServerClick(object sender, EventArgs e)
        {
            SupplierObject obj = new SupplierObject();

            obj.Supplier_NameProp = txtSupplierName.Value;
            obj.Address_Line_1Prop = txtSupplierAddress.Value;
            obj.Address_Line_2Prop = txtSupplierAddressLine2.Value;
            obj.CityProp = txtSupplierCity.Value;
            obj.CodeProp = txtSupplierCode.Value;
            obj.Telephone1Prop = txtSupplierTelephone.Value;
            obj.Telephone2Prop = txtSupplierTelephone2.Value;
            obj.FaxProp = txtSupplierFax.Value;
            obj.Cellphone1Prop = txtSupplierCellphone.Value;
            obj.EmailProp = txtSupplierEmail.Value;
            obj.RepresentativeProp = txtSupplierRepresentative.Value;
            obj.VAT_NumberProp = txtSupplierVATNumber.Value;
            obj.CK_NumberProp = txtSupplierCKNumber.Value;
            obj.DisableProp = chkBoxSupplierDisable.Checked;
            obj.Wholesale_SupplierProp = chkSupplierWholesale.Checked;

            ManageSupplier supplierObj = new ManageSupplier();

            bool success = supplierObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);



            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }
    }
}