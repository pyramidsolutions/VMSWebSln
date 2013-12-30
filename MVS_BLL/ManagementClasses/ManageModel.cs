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
    public class ManageModel
    {
        SqlConnection conn;
        public bool insert(ModelObject modelObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertModel", insertParameters(modelObj), conn);

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

        public List<SqlParameter> insertParameters(ModelObject modelObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Model_Name", modelObj.Model_Name));
            insertParamsArray.Add(new SqlParameter("@Vehicle_Type", modelObj.Vehicle_Type));
            insertParamsArray.Add(new SqlParameter("@Manufacturer_Name", modelObj.Manufacturer_Name));
            insertParamsArray.Add(new SqlParameter("@Disable", modelObj.Disable));
            return insertParamsArray;

        }

        public DataTable getModelInfo(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetAllModels", conn);

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

        public DataTable getAModel(string connectionString, int modelID)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetAModel", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Model_ID", modelID));

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

        public Boolean updateAModel(string connectionString, ModelObject modelObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateModel", insertParameters(modelObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Model_ID", rowIndex));

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

        public DataTable getModelList(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetModelList", conn);

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
    }
}
