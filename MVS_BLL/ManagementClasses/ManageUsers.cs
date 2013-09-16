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
    public class ManageUsers
    {
        SqlConnection conn;
        public  void insert(UserObject userObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertCompany", insertParameters(userObj), conn);

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


        public UserObject login(UserObject userObj, string connectionString)
        { 
            DataTable results = new DataTable();
            UserObject user = new UserObject();
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UserLogin", loginParameters(userObj), conn);

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                foreach (DataRow row in results.Rows)
                {
                    user.Account_Name = DBUtility.readDBString(row,"account_name");
                    user.Account_Password = DBUtility.readDBString(row,"account_password");
                    user.First_Name = DBUtility.readDBString(row,"first_name");
                    user.Surname = DBUtility.readDBString(row, "surname");
                    user.Account_Type = DBUtility.readDBString(row, "account_type");
                    user.Disable = Convert.ToInt32(row["Disable"]);
                    user.Email = DBUtility.readDBString(row, "email"); 

                }
                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return user;
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
        internal List<SqlParameter> insertParameters(UserObject userObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@account_name", userObj.Account_Name ));
            insertParamsArray.Add(new SqlParameter("@account_password", userObj.Account_Password ));
            insertParamsArray.Add(new SqlParameter("@first_name", userObj.First_Name));
            insertParamsArray.Add(new SqlParameter("@surname", userObj.Surname));
            insertParamsArray.Add(new SqlParameter("@account_type", userObj.Account_Type ));
            insertParamsArray.Add(new SqlParameter("@disable", userObj.Disable));
            insertParamsArray.Add(new SqlParameter("@email", userObj.Email));
           
            return insertParamsArray;

        }

        internal List<SqlParameter> loginParameters(UserObject userObj)
        {
            List<SqlParameter> loginParamsArray = new List<SqlParameter>();

            loginParamsArray.Add(new SqlParameter("@Username", userObj.Account_Name));
            loginParamsArray.Add(new SqlParameter("@Password", userObj.Account_Password));
            

            return loginParamsArray;

        }
    }
}
