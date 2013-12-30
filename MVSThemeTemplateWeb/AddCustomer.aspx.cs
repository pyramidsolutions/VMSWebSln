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
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveCustomer_ServerClick(object sender, EventArgs e)
        {
            CustomerObject obj = new CustomerObject();

            obj.Customer_NameProp = txtCustomerName.Value;
            obj.Address_Line_1Prop = txtCustomerAddress.Value;
            obj.Address_Line_2Prop = txtCustomerAddressLine2.Value;
            obj.CityProp = txtCustomerCity.Value;
            obj.CodeProp = txtCustomerCode.Value;
            obj.Telephone1Prop = txtCustomerTelephone.Value;
            obj.Telephone2Prop = txtCustomerTelephone2.Value;
            obj.FaxProp = txtCustomerFax.Value;
            obj.Cellphone1Prop = txtCustomerCellphone.Value;
            obj.EmailProp = txtCustomerEmail.Value;
            obj.RepresentativeProp = txtCustomerRepresentative.Value;
            obj.VAT_NumberProp = txtCustomerVATNumber.Value;
            obj.CK_NumberProp = txtCustomerCKNumber.Value;
            obj.DisableProp = chkBoxCustomerDisable.Checked;
            obj.Wholesale_CustomerProp = chkCustomerWholesaleCustomer.Checked;
            
            ManageCustomer customerObj = new ManageCustomer();

            bool success = customerObj.insert(obj,ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }
    }
}