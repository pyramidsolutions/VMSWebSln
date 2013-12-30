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
    public class ManageVehicle
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
            insertParamsArray.Add(new SqlParameter("@Cl", VehicleObj.CI));
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

        public DataTable getVehicleList(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetVehicleList", conn);

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

        public DataTable getVehicleCatalogue(string connectionString)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_GetVehicleCatalogue", conn);

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

        public DataTable searchVehicle(string connectionString, string searchString)
        {

            DataTable results = new DataTable();
           
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("sp_SearchForVehicles", conn);
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

        public VehicleObject getAVehicle(string connectionString, int Stock_Code)
        {

            DataTable results = new DataTable();
            VehicleObject vehicle = new VehicleObject();
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
                vehicle = getVehicleObject(results);
                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return vehicle;
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

        public Boolean updateAVehicle(string connectionString, VehicleObject VehicleObj, int rowIndex)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateVehicle", insertParameters(VehicleObj), conn);
                cmdIns.Parameters.Add(new SqlParameter("@Stock_Code", rowIndex));

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

        public VehicleObject getVehicleObject(DataTable dtVehicle)
        {
            VehicleObject vehicle = new VehicleObject();

            if (dtVehicle.Rows.Count > 0)
            {
                DataRow dr = dtVehicle.Rows[0];
                vehicle.AC = DBUtility.readDBBool(dr, "AC");
                vehicle.Airbag = DBUtility.readDBBool(dr, "Airbag");
                vehicle.AL = DBUtility.readDBBool(dr, "AL");
                vehicle.Arrival_Date =  DBUtility.readDBDate(dr, "Arrival_Date");
                vehicle.Automatic_Transmission = DBUtility.readDBBool(dr, "Automatic_Transmission");
                vehicle.CD = DBUtility.readDBBool(dr, "CD");
                vehicle.Chassis_Number = DBUtility.readDBString(dr, "Chassis_Number");
                vehicle.CI = DBUtility.readDBBool(dr, "Cl");
                vehicle.Colour = DBUtility.readDBString(dr, "Colour");
                vehicle.Condition = DBUtility.readDBString(dr,"Condition");
                vehicle.COR = DBUtility.readDBBool(dr, "COR");
                vehicle.Cost_Price = DBUtility.readDBDecimal(dr, "Cost_Price");
                vehicle.Engine_Number = DBUtility.readDBString(dr, "Engine_Number");
                vehicle.Extra_Features = DBUtility.readDBString(dr, "Extra_Features");
                vehicle.FSH = DBUtility.readDBBool(dr, "FSH");
                vehicle.Gearlock = DBUtility.readDBBool(dr, "Gearlock");
                vehicle.Leather = DBUtility.readDBBool(dr, "Leather");
                vehicle.Location_Name = DBUtility.readDBString(dr, "Location_Name");
                vehicle.Mags = DBUtility.readDBBool(dr, "Mags");
                vehicle.Manufacturer_Name = DBUtility.readDBString(dr, "Manufacturer_Name");
                vehicle.Mileage =  DBUtility.readDBInt(dr,"Mileage");
                vehicle.Model_Name =  DBUtility.readDBString(dr, "Model_Name");
                vehicle.MP3 =  DBUtility.readDBBool(dr,"MP3");
                vehicle.Picture_1 =  DBUtility.readDBImage(dr,"Picture_1");
                vehicle.Picture_2 = DBUtility.readDBImage(dr, "Picture_2");
                vehicle.Picture_3 = DBUtility.readDBImage(dr, "Picture_3");
                vehicle.PS = DBUtility.readDBBool(dr,"PS");
                vehicle.Registration_Number = DBUtility.readDBString(dr,"Registration_Number");
                vehicle.Retail_Price = DBUtility.readDBDecimal(dr,"Retail_Price");
                vehicle.RT = DBUtility.readDBBool(dr,"RT");
                vehicle.Sports_Kit = DBUtility.readDBBool(dr,"Sports_Kit");
                vehicle.SR = DBUtility.readDBBool(dr, "SR");
                vehicle.Supplier_NameProp = DBUtility.readDBString(dr,"Supplier_Name");
                vehicle.Vehicle_Status = DBUtility.readDBString(dr,"Vehicle_Status");
                vehicle.Wholesale_Price = DBUtility.readDBDecimal(dr,"Wholesale_Price");
            }

            return vehicle;
        }
    }
}
