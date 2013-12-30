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
    public class ManageCustomer  
    {
        SqlConnection conn;
        public  bool insert(CustomerObject CustomerObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertCustomer", insertParameters(CustomerObj), conn);
            
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

        public List <SqlParameter> insertParameters(CustomerObject customerObj)
        {
            List <SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Customer_name", customerObj.Customer_NameProp));
            insertParamsArray.Add(new SqlParameter("@Address_Line_1", customerObj.Address_Line_1Prop));
            insertParamsArray.Add(new SqlParameter("@Address_Line_2", customerObj.Address_Line_2Prop));
            insertParamsArray.Add(new SqlParameter("@City", customerObj.CityProp));
            insertParamsArray.Add(new SqlParameter("@Code", customerObj.CodeProp));
            insertParamsArray.Add(new SqlParameter("@Telephone1", customerObj.Telephone1Prop));
            insertParamsArray.Add(new SqlParameter("@Telephone2", customerObj.Telephone2Prop));
            insertParamsArray.Add(new SqlParameter("@Fax", customerObj.FaxProp));
            insertParamsArray.Add(new SqlParameter("@Email", customerObj.EmailProp));
            insertParamsArray.Add(new SqlParameter("@Wholesale_Customer", customerObj.Wholesale_CustomerProp));
            insertParamsArray.Add(new SqlParameter("@Cellphone", customerObj.Cellphone1Prop));
            insertParamsArray.Add(new SqlParameter("@VAT_Number", customerObj.VAT_NumberProp ));
            insertParamsArray.Add(new SqlParameter("@Representative", customerObj.RepresentativeProp));
            insertParamsArray.Add(new SqlParameter("@CK_Number", customerObj.CK_NumberProp));
            insertParamsArray.Add(new SqlParameter("@Disable", customerObj.DisableProp));

            return insertParamsArray;

        }

        public DataTable getCustomerInfo(string connectionString)
        {
            
            DataTable results = new DataTable();
          
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetAllCustomers", conn);

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

        public DataTable getACustomer(string connectionString, int customerCode)
        {

            DataTable results = new DataTable();
           
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetACustomer", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Customer_Code", customerCode));

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

        public CustomerObject getCustomerObject (string connectionString, int customerCode)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetACustomer", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Customer_Code", customerCode));

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return populateCustomer(results.Rows[0], connectionString);
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

        public Boolean updateACustomer(string connectionString, CustomerObject customerObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateCustomer", insertParameters(customerObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Customer_Code", rowIndex));

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

        public DataTable searchCustomer(string connectionString, string searchString)
        {

            DataTable results = new DataTable();
          
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_SearchForCustomers", conn);
                SqlParameter param = new SqlParameter("@Search_String", searchString);
                cmdIns.Parameters.Add(param);
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

        public CustomerObject populateCustomer(DataRow dr, string connectionString)
        {
            CustomerObject customerObject = new CustomerObject();

            if (dr != null)
            {
                customerObject.Address_Line_1Prop = DBUtility.readDBString(dr, "Address_Line_1");
                customerObject.Address_Line_2Prop = DBUtility.readDBString(dr, "Address_Line_2");
                customerObject.Cellphone1Prop = DBUtility.readDBString(dr, "Cellphone");
                customerObject.CityProp = DBUtility.readDBString(dr, "City");
                customerObject.CK_NumberProp = DBUtility.readDBString(dr, "CK_number");
                customerObject.CodeProp = DBUtility.readDBString(dr, "Code");
                customerObject.Customer_NameProp = DBUtility.readDBString(dr, "Customer_name");
                customerObject.DisableProp = DBUtility.readDBBool(dr, "Disable");
                customerObject.EmailProp = DBUtility.readDBString(dr, "email");
                customerObject.FaxProp = DBUtility.readDBString(dr, "fax");
                customerObject.RepresentativeProp = DBUtility.readDBString(dr, "Representative");
                customerObject.Telephone1Prop = DBUtility.readDBString(dr, "telephone_1");
                customerObject.Telephone2Prop = DBUtility.readDBString(dr, "telephone_2");
                customerObject.VAT_NumberProp = DBUtility.readDBString(dr, "VAT_number");
                customerObject.Wholesale_CustomerProp = DBUtility.readDBBool(dr, "wholesale_customer");

            }

            return customerObject;
        }
    }
}

