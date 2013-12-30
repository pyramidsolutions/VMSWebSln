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
using System.Data;


namespace MVS_BLL.ManagementClasses
{
    public class ManageCompany  
    {
        SqlConnection conn;
        public  bool insert(CompanyObject CompanyObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertCompany", insertParameters(CompanyObj), conn);
            
                int rowsUpdated = cmdIns.ExecuteNonQuery();

            //    cmdIns.Parameters.Clear();
            //    cmdIns.CommandText = "SELECT @@IDENTITY";

            //    // Get the last inserted id.
            //    int insertID = Convert.ToInt32(cmdIns.ExecuteScalar());
               
                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                if (rowsUpdated > 0)
                {
                    return true;
                }
                else return false;
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

        public List <SqlParameter> insertParameters(CompanyObject companyObj)
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

        public DataTable getCompanyInfo(string connectionString)
        {
            
            DataTable results = new DataTable();
          
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetCompanyInfo", conn);

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return results;
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

        public DataTable getACompany(string connectionString, int companyID)
        {

            DataTable results = new DataTable();
           
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetACompany", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Company_ID", companyID));

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return results;
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

        public CompanyObject getACompanyObject(string connectionString, int companyID)
        {

            DataTable results = new DataTable();
            CompanyObject company = new CompanyObject();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetACompany", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Company_ID", companyID));

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();

                 return populateCompany(results.Rows[0], connectionString);
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

        public Boolean updateACompany(string connectionString, CompanyObject companyObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateCompany", insertParameters(companyObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Company_ID",rowIndex));

                int rowsUpdated = cmdIns.ExecuteNonQuery();

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();

                if (rowsUpdated > 0)
                {
                    return true;
                }
                else return false;


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

        public CompanyObject populateCompany(DataRow dr, string connectionString)
        {
            CompanyObject companyObject = new CompanyObject();
            
            if (dr != null)
            {
                companyObject.Address_Line_1Prop = DBUtility.readDBString(dr, "Address_Line_1");
                companyObject.Address_Line_2Prop = DBUtility.readDBString(dr, "Address_Line_2");
                companyObject.CityProp = DBUtility.readDBString(dr, "City");
                companyObject.CodeProp = DBUtility.readDBString(dr, "Code");
                companyObject.Company_LogoProp = DBUtility.readDBImage(dr, "Company_logo");
                companyObject.Company_NameProp = DBUtility.readDBString(dr, "Company_name");
                companyObject.DisableProp = DBUtility.readDBBool(dr, "Disable");
                companyObject.EmailProp = DBUtility.readDBString(dr, "email");
                companyObject.FaxProp = DBUtility.readDBString(dr, "fax");
                companyObject.Invoice_FooterProp = DBUtility.readDBString(dr, "Invoice_Footer");
                companyObject.Telephone1Prop = DBUtility.readDBString(dr, "telephone_1");
                companyObject.Telephone2Prop = DBUtility.readDBString(dr, "telephone_2");
                companyObject.VAT_NumberProp = DBUtility.readDBString(dr, "VAT_number");
                companyObject.VAT_percentageProp = DBUtility.readDBInt(dr, "VAT_percentage");
                companyObject.WebsiteProp = DBUtility.readDBString(dr, "website");
            }

            return companyObject;
        }
  }
}
