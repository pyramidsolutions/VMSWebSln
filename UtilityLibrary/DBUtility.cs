using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public static class DBUtility
    {
        

         public static  SqlConnection createConnection(string connStr)
        {
            SqlConnection myConnection;
            try
            {
                myConnection = new SqlConnection(connStr);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("SQL Connection creation failed", ex);
            }
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("SQL Open failed", ex);
            }

            return myConnection;
        }


        public static void Close(SqlConnection myConnection)
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }


        internal static string State(SqlConnection myConnection)
        {
            return myConnection.State.ToString();
        }

        public static SqlCommand PrepareSPCommand(string storedProcName, List<SqlParameter> parameters, SqlConnection sqlConn)
        {
            SqlCommand command = new SqlCommand(storedProcName, sqlConn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());
            
            return command;
        }


        

        public static string readDBString(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (string)row[fieldName] + " ";
            else
                return String.Empty;
        }
   
    }
}
