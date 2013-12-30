using MVS_BLL.CustomDataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace MVS_BLL.ManagementClasses
{
    public class ManageSupplier
    {
        SqlConnection conn;
        public bool insert(SupplierObject SupplierObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertSupplier", insertParameters(SupplierObj), conn);

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

        public List<SqlParameter> insertParameters(SupplierObject supplierObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Supplier_name", supplierObj.Supplier_NameProp));
            insertParamsArray.Add(new SqlParameter("@Address_Line_1", supplierObj.Address_Line_1Prop));
            insertParamsArray.Add(new SqlParameter("@Address_Line_2", supplierObj.Address_Line_2Prop));
            insertParamsArray.Add(new SqlParameter("@City", supplierObj.CityProp));
            insertParamsArray.Add(new SqlParameter("@Code", supplierObj.CodeProp));
            insertParamsArray.Add(new SqlParameter("@Telephone1", supplierObj.Telephone1Prop));
            insertParamsArray.Add(new SqlParameter("@Telephone2", supplierObj.Telephone2Prop));
            insertParamsArray.Add(new SqlParameter("@Fax", supplierObj.FaxProp));
            insertParamsArray.Add(new SqlParameter("@Email", supplierObj.EmailProp));
            insertParamsArray.Add(new SqlParameter("@Wholesale_Supplier", supplierObj.Wholesale_SupplierProp));
            insertParamsArray.Add(new SqlParameter("@Cellphone", supplierObj.Cellphone1Prop));
            insertParamsArray.Add(new SqlParameter("@VAT_Number", supplierObj.VAT_NumberProp));
            insertParamsArray.Add(new SqlParameter("@Representative", supplierObj.RepresentativeProp));
            insertParamsArray.Add(new SqlParameter("@CK_Number", supplierObj.CK_NumberProp));
            insertParamsArray.Add(new SqlParameter("@Disable", supplierObj.DisableProp));

            return insertParamsArray;

        }

        public DataTable getSupplierInfo(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetAllSuppliers", conn);

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

        public DataTable getSupplierList(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetSupplierList", conn);

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

        public DataTable getASupplier(string connectionString, int supplier_Code)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetASupplier", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Supplier_Code", supplier_Code));

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

        public Boolean updateASupplier(string connectionString, SupplierObject supplierObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateSupplier", insertParameters(supplierObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Supplier_Code", rowIndex));

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
    }
}
