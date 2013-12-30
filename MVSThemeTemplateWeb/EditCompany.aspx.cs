using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System.Configuration;
using System.Data;
using UtilityLibrary;

namespace MVSThemeTemplateWeb
{
    public partial class EditCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void loadCompanyTable()
        {
            
        }

        protected void grdCompany_Load(object sender, EventArgs e)
        {
            ManageCompany companyObj = new ManageCompany();
            grdCompany.DataSource = companyObj.getCompanyInfo(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            grdCompany.DataBind();
        }

        protected void grdCompany_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            Session.Add("rowIndex", rowIndex);
            ManageCompany companyObj = new ManageCompany();
            DataTable dt = companyObj.getACompany(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, rowIndex);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtCompanyName.Value = DBUtility.readDBString(dr,"Company_Name");
                txtCompanyAddress.Value = DBUtility.readDBString(dr,"Address_Line_1");
                txtCompanyAddressLine2.Value = DBUtility.readDBString(dr,"Address_Line_2");
                txtCompanyCity.Value = DBUtility.readDBString(dr, "City");
                txtCompanyCode.Value = DBUtility.readDBString(dr, "Code");
                txtCompanyTelephone.Value = DBUtility.readDBString(dr, "telephone_1");
                txtCompanyTelephone2.Value = DBUtility.readDBString(dr, "telephone_2");
                txtCompanyFax.Value = DBUtility.readDBString(dr, "fax");
                txtCompanyEmail.Value = DBUtility.readDBString(dr, "email");
                txtCompanyWebsite.Value = DBUtility.readDBString(dr, "website");
                txtCompanyVATNumbwer.Value = DBUtility.readDBString(dr, "VAT_Number");
                txtCompanyVATPercentage.Value = DBUtility.readDBString(dr, "VAT_percentage");
                if (dr["Disable"] != null && !dr.IsNull("Disable"))
                {
                    chkBoxCompanyDisable.Checked = Convert.ToBoolean(dr["Disable"]);
                }
            }

            


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
            obj.VAT_NumberProp= txtCompanyVATNumbwer.Value;
            obj.Invoice_FooterProp = "";
            if (txtCompanyVATPercentage.Value != "")
                obj.VAT_percentageProp = int.Parse(txtCompanyVATPercentage.Value);
            if ( fileUplaodCompanyLogo.PostedFile != null )
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

            bool success = companyObj.updateACompany(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, obj, Convert.ToInt32(Session["rowIndex"]));

            Session.Remove("rowIndex");

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
        }

        
    }
}