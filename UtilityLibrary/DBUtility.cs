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

        public static SqlCommand PrepareReadCommand(string storedProcName, SqlConnection sqlConn)
        {
            SqlCommand command = new SqlCommand(storedProcName, sqlConn);
            command.CommandType = CommandType.StoredProcedure;
            
            return command;
        }
        

        public static string readDBString(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return row[fieldName] + " ";
            else
                return String.Empty;
        }

        public static byte[] readDBImage(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (byte[])row[fieldName];
            else
                return null;
        }

        public static bool readDBBool(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (bool)row[fieldName];
            else
                return false;
        }

        public static DateTime readDBDate(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (DateTime)row[fieldName];
            else
                return DateTime.Now;
        }

        public static decimal readDBDecimal(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (Decimal)row[fieldName];
            else
                return 0;
        }

        public static int readDBInt(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (int)row[fieldName];
            else
                return 0;
        }

        public static DataTable CloneTable(DataTable originalTable)
        {

            DataTable newTable;
            newTable = originalTable.Clone();

            return newTable;

        }
    }
}
