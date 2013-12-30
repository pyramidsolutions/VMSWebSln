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
    public class ManageInvoices
    {
        SqlConnection conn;
        public bool insert(InvoiceObject InvoiceObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_InsertInvoice", insertParameters(InvoiceObj), conn);

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

        public List<SqlParameter> insertParameters(InvoiceObject invoiceObj)
        {
            List<SqlParameter> insertParamsArray = new List<SqlParameter>();

            insertParamsArray.Add(new SqlParameter("@Company_Name", invoiceObj.CompanyInfo.Company_NameProp));
            insertParamsArray.Add(new SqlParameter("@Invoice_Date", invoiceObj.InvoiceDate));
            insertParamsArray.Add(new SqlParameter("@Due_Date", invoiceObj.DueDate));
            insertParamsArray.Add(new SqlParameter("@Status", invoiceObj.InvoiceStatus));
            insertParamsArray.Add(new SqlParameter("@Subtotal", invoiceObj.SubTotal));
            insertParamsArray.Add(new SqlParameter("@Discount", invoiceObj.Discount));
            insertParamsArray.Add(new SqlParameter("@VATAmount", invoiceObj.VATAmount));
            insertParamsArray.Add(new SqlParameter("@GrandTotal", invoiceObj.GrandTotal));
            insertParamsArray.Add(new SqlParameter("@Username", invoiceObj.User.Account_Name));
            insertParamsArray.Add(new SqlParameter("@CustomerName", invoiceObj.Customer.Customer_NameProp));
            
            return insertParamsArray;

        }

        public List<SqlParameter> updateParameters(InvoiceObject invoiceObj)
        {
            List<SqlParameter> updateParams = new List<SqlParameter>();

            updateParams.Add(new SqlParameter("@Due_Date", invoiceObj.DueDate));
            updateParams.Add(new SqlParameter("@Status", invoiceObj.InvoiceStatus));
            updateParams.Add(new SqlParameter("@Subtotal", invoiceObj.SubTotal));
            updateParams.Add(new SqlParameter("@Discount", invoiceObj.Discount));
            updateParams.Add(new SqlParameter("@VATAmount", invoiceObj.VATAmount));
            updateParams.Add(new SqlParameter("@GrandTotal", invoiceObj.GrandTotal));
            updateParams.Add(new SqlParameter("@Invoice_Number", invoiceObj.InvoiceNumber));

            return updateParams;

        }
        public InvoiceObject getInvoiceInfo(int invoice_Number, string connectionString, UserObject user)
        {

            DataTable results = new DataTable();

            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareReadCommand("GetAnInvoice", conn);
                cmdIns.Parameters.Add( new SqlParameter("@Invoice_Number", invoice_Number));

                using (conn)
                using (cmdIns)
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdIns))
                {
                    dataAdapter.Fill(results);
                }

                var invoice = populateInvoice(results.Rows[0], connectionString, user);

                cmdIns.Dispose();
                DBUtility.Close(conn);
                conn.Dispose();
                return invoice;
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

        private InvoiceObject populateInvoice(DataRow dataRow, string connectionString, UserObject userObject)
        {
            InvoiceObject invoice = new InvoiceObject();

            if (dataRow != null)
            {
                int companyID = DBUtility.readDBInt(dataRow, "Company_ID");
                int customer_code = DBUtility.readDBInt(dataRow, "Customer_Code");
                invoice.CompanyInfo = new ManageCompany().getACompanyObject(connectionString, companyID);
                invoice.Customer = new ManageCustomer().getCustomerObject(connectionString, customer_code);
                invoice.Discount = DBUtility.readDBInt(dataRow, "Discount");
                invoice.DueDate = DBUtility.readDBDate(dataRow, "Due_Date");
                invoice.GrandTotal = DBUtility.readDBDecimal(dataRow, "GrandTotal");
                invoice.InvoiceDate = DBUtility.readDBDate(dataRow, "Invoice_Date");
                invoice.InvoiceNumber = DBUtility.readDBInt(dataRow, "Invoice_Number");
                invoice.InvoiceStatus = (MVS_Enum.CommonEnums.InvoiceStatus)Enum.Parse(typeof(MVS_Enum.CommonEnums.InvoiceStatus), DBUtility.readDBString(dataRow, "Status"));
                invoice.SubTotal = DBUtility.readDBDecimal(dataRow, "SubTotal");
                invoice.User = userObject;
            }

            return invoice;
        }

        public bool update(InvoiceObject InvoiceObj, string connectionString)
        {
            try
            {
                conn = DBUtility.createConnection(connectionString);
                SqlCommand cmdIns = DBUtility.PrepareSPCommand("sp_UpdateInvoice", updateParameters(InvoiceObj), conn);

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
