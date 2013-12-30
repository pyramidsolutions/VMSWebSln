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
    public partial class AddCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveCompany_ServerClick(object sender, EventArgs e)
        {
            CompanyObject obj = new CompanyObject();

            obj.Company_NameProp = txtCompanyName.Value;
            obj.Address_Line_1Prop = txtCompanyAddress.Value;
            obj.Address_Line_2Prop = txtCompanyAddressLine2.Value;
            obj.CityProp = txtCompanyCity.Value;
            obj.CodeProp = txtCompanyCode.Value;
            obj.Telephone1Prop = txtCompanyTelephone.Value;
            obj.Telephone2Prop = txtCompanyTelephone2.Value;
            obj.FaxProp = txtCompanyFax.Value;
            obj.EmailProp = txtCompanyEmail.Value;
            obj.WebsiteProp = txtCompanyWebsite.Value;
            obj.VAT_NumberProp = txtCompanyVATNumbwer.Value;
            obj.Invoice_FooterProp = "";
            if (txtCompanyVATPercentage.Value != "")
                obj.VAT_percentageProp = int.Parse(txtCompanyVATPercentage.Value);
            if (fileUplaodCompanyLogo.PostedFile != null)
            {
                Byte[] bytes;
                using (System.IO.BinaryReader r = new System.IO.BinaryReader(fileUplaodCompanyLogo.PostedFile.InputStream))
                {
                    // Read the data from the stream into the byte array
                    bytes = r.ReadBytes(Convert.ToInt32(fileUplaodCompanyLogo.PostedFile.ContentLength));
                }

                obj.Company_LogoProp = bytes;
            }
            obj.DisableProp = chkBoxCompanyDisable.Checked;

            ManageCompany companyObj = new ManageCompany();

            bool success = companyObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }

    }
}