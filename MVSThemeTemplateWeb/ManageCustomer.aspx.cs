using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVS_BLL.CustomDataObjects;

namespace MVSThemeTemplateWeb
{
    public partial class ManageCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdCompany_Load(object sender, EventArgs e)
        {
            ManageCustomer companyObj = new ManageCustomer();
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
                txtCompanyName.Value = DBUtility.readDBString(dr, "Company_Name");
                txtCompanyAddress.Value = DBUtility.readDBString(dr, "Address_Line_1");
                txtCompanyAddressLine2.Value = DBUtility.readDBString(dr, "Address_Line_2");
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

    }
}