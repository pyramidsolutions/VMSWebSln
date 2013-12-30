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
    public class ManageServiceProviderCategory
    {
        SqlConnection conn;
        public bool insert(VehicleObject VehicleObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertVehicle", insertParameters(VehicleObj), conn);

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

        public List<SqlParameter> insertParameters(VehicleObject VehicleObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Manufacturer_Name", VehicleObj.Manufacturer_Name));
            insertParamsArray.Add(new SqlParameter("@Model_Name", VehicleObj.Model_Name));
            insertParamsArray.Add(new SqlParameter("@Location_Name", VehicleObj.Location_Name));
            insertParamsArray.Add(new SqlParameter("@Supplier_Name", VehicleObj.Supplier_NameProp));
            insertParamsArray.Add(new SqlParameter("@Cost_Price", VehicleObj.Cost_Price));
            insertParamsArray.Add(new SqlParameter("@Retail_Price", VehicleObj.Retail_Price));
            insertParamsArray.Add(new SqlParameter("@Wholesale_Price", VehicleObj.Wholesale_Price));
            insertParamsArray.Add(new SqlParameter("@Colour", VehicleObj.Colour));
            insertParamsArray.Add(new SqlParameter("@Picture_1", VehicleObj.Picture_1));
            insertParamsArray.Add(new SqlParameter("@Picture_2", VehicleObj.Picture_2));
            insertParamsArray.Add(new SqlParameter("@Picture_3", VehicleObj.Picture_3));
            insertParamsArray.Add(new SqlParameter("@Chassis_Number", VehicleObj.Chassis_Number));
            insertParamsArray.Add(new SqlParameter("@Engine_Number", VehicleObj.Engine_Number));
            insertParamsArray.Add(new SqlParameter("@Registration_Number", VehicleObj.Registration_Number));
            insertParamsArray.Add(new SqlParameter("@Extra_Features", VehicleObj.Extra_Features));
            insertParamsArray.Add(new SqlParameter("@Mileage", VehicleObj.Mileage));
            insertParamsArray.Add(new SqlParameter("@Automatic_Transmission", VehicleObj.Automatic_Transmission));
            insertParamsArray.Add(new SqlParameter("@COR", VehicleObj.COR));
            insertParamsArray.Add(new SqlParameter("@AC", VehicleObj.AC));
            insertParamsArray.Add(new SqlParameter("@CI", VehicleObj.CI));
            insertParamsArray.Add(new SqlParameter("@PS", VehicleObj.PS));
            insertParamsArray.Add(new SqlParameter("@AL", VehicleObj.AL));
            insertParamsArray.Add(new SqlParameter("@Leather", VehicleObj.Leather));
            insertParamsArray.Add(new SqlParameter("@RT", VehicleObj.RT));
            insertParamsArray.Add(new SqlParameter("@CD", VehicleObj.CD));
            insertParamsArray.Add(new SqlParameter("@MP3", VehicleObj.MP3));
            insertParamsArray.Add(new SqlParameter("@FSH", VehicleObj.FSH));
            insertParamsArray.Add(new SqlParameter("@SR", VehicleObj.SR));
            insertParamsArray.Add(new SqlParameter("@Sports_Kit", VehicleObj.Sports_Kit));
            insertParamsArray.Add(new SqlParameter("@Airbag", VehicleObj.Airbag));
            insertParamsArray.Add(new SqlParameter("@Mags", VehicleObj.Mags));
            insertParamsArray.Add(new SqlParameter("@Gearlock", VehicleObj.Gearlock));
            insertParamsArray.Add(new SqlParameter("@Condition", VehicleObj.Condition));
            insertParamsArray.Add(new SqlParameter("@Arrival_Date", VehicleObj.Arrival_Date));
            insertParamsArray.Add(new SqlParameter("@Vehicle_Status", VehicleObj.Vehicle_Status));
            return insertParamsArray;

        }


        public DataTable getAllVehicles(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetAllVehicles", conn);

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

        public DataTable getServiceProviderCategoryList(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetSPCategoriesList", conn);

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

        public DataTable getAVehicle(string connectionString, int Stock_Code)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetAVehicle", conn);

                cmdIns.Parameters.Add(new SqlParameter("@Stock_Code", Stock_Code));

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
