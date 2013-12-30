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
    public class ManageImprovement
    {
        SqlConnection conn;
        public bool insert(ImprovementObject ImprovementObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertImprovement", insertParameters(ImprovementObj), conn);

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

        public List<SqlParameter> insertParameters(ImprovementObject improvementObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Improvement_Name", improvementObj.Improvement_Name));
            insertParamsArray.Add(new SqlParameter("@Improvement_Description", improvementObj.Improvement_Description));
            insertParamsArray.Add(new SqlParameter("@Improvement_Price", improvementObj.Improvement_price));
            insertParamsArray.Add(new SqlParameter("@SP_ID", improvementObj.SP_ID));
            insertParamsArray.Add(new SqlParameter("@Stock_Code", improvementObj.Stock_Code));
            insertParamsArray.Add(new SqlParameter("@Disable", improvementObj.Disable));

            return insertParamsArray;

        }

        public DataTable getImprovementInfo(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetAllImprovements", conn);

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

        public DataTable getAnImprovement(string connectionString, int improvementID)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetAnImprovement", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Improvement_ID", improvementID));

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

        public Boolean updateAnImprovement(string connectionString, ImprovementObject improvementObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateImprovement", insertParameters(improvementObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Improvement_ID", rowIndex));

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
