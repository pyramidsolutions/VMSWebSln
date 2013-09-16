using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVS_BLL.CustomDataObjects;
using System.Data.SqlClient;
using UtilityLibrary;
using System.Data.SqlTypes;
using System.Reflection;


namespace MVS_BLL.ManagementClasses
{
    class ManageCompany  
    {
        SqlConnection conn;
        public  void insert(CompanyObject CompanyObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertCompany", insertParameters(CompanyObj), conn);
            
                cmdIns.ExecuteNonQuery();

            //    cmdIns.Parameters.Clear();
            //    cmdIns.CommandText = "SELECT @@IDENTITY";

            //    // Get the last inserted id.
            //    int insertID = Convert.ToInt32(cmdIns.ExecuteScalar());

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
            
            }
            catch (Exception ex)
            {
               throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                DBUtility.Close(conn);
                conn.Dispose();
            }
        }

        internal List <SqlParameter> insertParameters(CompanyObject companyObj)
        {
            List <SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Company_name", companyObj.Company_NameProp));
            insertParamsArray.Add(new SqlParameter("@Address_Line_1", companyObj.Address_Line_1Prop));
            insertParamsArray.Add(new SqlParameter("@Address_Line_2", companyObj.Address_Line_2Prop));
            insertParamsArray.Add(new SqlParameter("@City", companyObj.CityProp));
            insertParamsArray.Add(new SqlParameter("@Code", companyObj.CodeProp));
            insertParamsArray.Add(new SqlParameter("@Telephone1", companyObj.Telephone1Prop));
            insertParamsArray.Add(new SqlParameter("@Telephone2", companyObj.Telephone2Prop));
            insertParamsArray.Add(new SqlParameter("@Fax", companyObj.FaxProp));
            insertParamsArray.Add(new SqlParameter("@Email", companyObj.EmailProp));
            insertParamsArray.Add(new SqlParameter("@Website", companyObj.WebsiteProp));
            insertParamsArray.Add(new SqlParameter("@VAT_Number", companyObj.VAT_NumberProp ));
            insertParamsArray.Add(new SqlParameter("@VAT_Percentage", companyObj.VAT_percentageProp));
            insertParamsArray.Add(new SqlParameter("@Invoice_Footer", companyObj.Invoice_FooterProp));
            insertParamsArray.Add(new SqlParameter("@Company_Logo", companyObj.Company_LogoProp));
            insertParamsArray.Add(new SqlParameter("@disable", companyObj.DisableProp));

            return insertParamsArray;

        }
  }
}
