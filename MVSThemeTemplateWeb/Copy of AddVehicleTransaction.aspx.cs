using MVS_BLL.ManagementClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilityLibrary;

namespace MVSThemeTemplateWeb
{
    public partial class AddVehicleTransaction : System.Web.UI.Page
    {
        ImageUtility imageUtil;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TRANSACTION_VEHICLES"] != null && Session["TRANSACTION_CUSTOMER"] != null)
            {
                invoiceLoad(sender, e);
            }
        }

        #region  Vehicles Tab

        protected void btnSearch_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchVehicles.Value.Length > 0)
                {
                    ManageVehicle manager = new ManageVehicle();
                    var vehicleList = manager.searchVehicle(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, txtSearchVehicles.Value);
                    if (vehicleList != null && vehicleList.Rows.Count > 0)
                    {
                        nothingFound.Visible = false;
                        if (Session["SEARCH_VEHICLES"] != null)
                        {
                            Session.Remove("SEARCH_VEHICLES");
                        }
                        Session.Add("SEARCH_VEHICLES", vehicleList);
                        bindVehicles();
                    }
                    else
                    {
                        nothingFound.Visible = true;
                        grdVehicles.DataSource = null;
                        grdVehicles.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {

               
            }
            
        }

        protected void grdVehicles_RowCreated(object sender, GridViewRowEventArgs e)
        {
           if(e.Row.RowType == DataControlRowType.DataRow)
           {
                Image image = e.Row.FindControl("vehicleImage") as Image;
                DataTable vehicleList = Session["SEARCH_VEHICLES"] as DataTable;
                GridViewRow row = e.Row;
                int index = e.Row.DataItemIndex;

                if (image != null)
                {   
                    DataRow dr = vehicleList.Rows[index];
                    imageUtil = new ImageUtility();
                    byte[] picture1 = DBUtility.readDBImage(dr,"Picture_1");
                    if (image != null && picture1 != null)
                    {
                        image.ImageUrl = imageUtil.byteArrayToBase64String(picture1);
                    }
                    
                
                }

              
            }
        }

        protected void btnAddtoTransaction_ServerClick(object sender, EventArgs e)
        {
            Button addVehicleButton = sender as Button;
            int stock_ID = int.Parse( addVehicleButton.CommandArgument);
            if (Session["TRANSACTION_VEHICLES"] != null)
            {
                var addedVehicles = Session["TRANSACTION_VEHICLES"] as DataTable;
                DataTable vehicleList = Session["SEARCH_VEHICLES"] as DataTable;
                DataRow dr = vehicleList.Rows[stock_ID];

                addedVehicles.ImportRow(dr);

                Session["TRANSACTION_VEHICLES"] = addedVehicles;
            }
            else
            {
                
                DataTable vehicleList = Session["SEARCH_VEHICLES"] as DataTable;
                DataTable addedVehicles = DBUtility.CloneTable(vehicleList);
                DataRow dr = vehicleList.Rows[stock_ID];

                addedVehicles.ImportRow(dr);

                Session.Add("TRANSACTION_VEHICLES",addedVehicles);
            }
        }

        protected void grdVehicles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                Button addVehicleButton = e.CommandSource as Button;
                if (addVehicleButton.CommandName == "AddVehicle")
                {
                    int stock_ID = int.Parse(addVehicleButton.CommandArgument);
                    if (Session["TRANSACTION_VEHICLES"] != null)
                    {
                        var addedVehicles = Session["TRANSACTION_VEHICLES"] as DataTable;
                        DataTable vehicleList = Session["SEARCH_VEHICLES"] as DataTable;

                        DataRow dr = vehicleList.Select("Stock_Code = '" + stock_ID + "'").FirstOrDefault<DataRow>();

                        addedVehicles.ImportRow(dr);

                        Session["TRANSACTION_VEHICLES"] = addedVehicles;

                    }
                    else
                    {

                        DataTable vehicleList = Session["SEARCH_VEHICLES"] as DataTable;
                        DataTable addedVehicles = DBUtility.CloneTable(vehicleList);
                        DataRow dr = vehicleList.Select("Stock_Code = '" + stock_ID + "'").FirstOrDefault<DataRow>();

                        addedVehicles.ImportRow(dr);

                        Session.Add("TRANSACTION_VEHICLES", addedVehicles);
                    }

                    //bind transaction vehicles

                    grdTransactionVehicles.DataSource = Session["TRANSACTION_VEHICLES"];
                    grdTransactionVehicles.DataBind();

                    // bind search vehicles
                    grdVehicles.DataSource = Session["SEARCH_VEHICLES"];
                    grdVehicles.DataBind();
                }

            }
            catch (Exception er)
            {
 
            }
        }

        protected void grdVehicles_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               
                //check if row exists in added vehicles
                HiddenField hdnStock_ID = e.Row.FindControl("hdnStock_Id") as HiddenField;
                Button btnAddtoTransaction = e.Row.FindControl("btnAddtoTransaction") as Button;
                if (Session["TRANSACTION_VEHICLES"] != null)
                {

                    int stock_ID = int.Parse(btnAddtoTransaction.CommandArgument);
                    var addedVehicles = Session["TRANSACTION_VEHICLES"] as DataTable;
                    try
                    {
                        var foundVehicles = addedVehicles.Select("Stock_Code = '" + hdnStock_ID.Value + "'");
                        if (foundVehicles != null && foundVehicles.Length > 0)
                        {
                            btnAddtoTransaction.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        

                    }
                   
                }
            }
        }

        protected void grdVehicles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdVehicles.PageIndex = e.NewPageIndex;
            bindVehicles();
        }

        private void bindVehicles()
        {
            if (Session["SEARCH_VEHICLES"] !=  null)
            {
                grdVehicles.DataSource = Session["SEARCH_VEHICLES"];
                grdVehicles.DataBind();
            }
        }
        #endregion

        #region Customers Tab

        protected void btnSearchCustomers_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchCustomers.Value.Length > 0)
                {
                    ManageCustomer manager = new ManageCustomer();
                    var customerList = manager.searchCustomer(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, txtSearchCustomers.Value);
                    if (customerList != null && customerList.Rows.Count > 0)
                    {
                        divCustomersNothingFound.Visible = false;
                        if (Session["SEARCH_CUSTOMERS"] != null)
                        {
                            Session.Remove("SEARCH_CUSTOMERS");
                        }
                        Session.Add("SEARCH_CUSTOMERS", customerList);
                        grdCustomers.DataSource = Session["SEARCH_CUSTOMERS"];
                        grdCustomers.DataBind();
                    }
                    else
                    {
                        divCustomersNothingFound.Visible = true;
                        grdCustomers.DataSource = null;
                        grdCustomers.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
 
            }
        }

        protected void grdCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomers.PageIndex = e.NewPageIndex;
            bindVehicles();
        }
      
        private void bindCustomers()
        {
            if (Session["SEARCH_CUSTOMERS"] != null)
            {
                grdCustomers.DataSource = Session["SEARCH_CUSTOMERS"];
                grdCustomers.DataBind();
            }
        } 
   
        protected void grdCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdCustomers.Rows)
            {
                if (row.RowIndex == grdCustomers.SelectedIndex)
                {
                    HiddenField hdnField = row.FindControl("hdnCustomer_Id") as HiddenField;
                    row.BackColor = System.Drawing.ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                    if (hdnField != null && hdnField.Value != null)
                    {
                        if (Session["TRANSACTION_CUSTOMER"] != null)
                        {
                            Session["TRANSACTION_CUSTOMER"] = hdnField.Value;
                        }
                        else
                        {
                            Session.Add("TRANSACTION_CUSTOMER", hdnField.Value);
                        }
                    }
                }
                else
                {
                    row.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }

        protected void grdCustomers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grdCustomers, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        #endregion

        #region Create Invoice Tab

        protected void invoiceLoad(object sender, EventArgs e)
        {
            try
            {
                txtDate.Value = DateTime.Now.Date.ToShortDateString();

                //set customer details
                if (Session["TRANSACTION_CUSTOMER"] != null)
                {
                    var customer = new ManageCustomer().getACustomer(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, int.Parse(Session["TRANSACTION_CUSTOMER"].ToString()));
                    if (customer.Rows.Count > 0)
                    {
                        DataRow dr = customer.Rows[0];
                        txtCustomerName.Value = DBUtility.readDBString(dr, "Customer_name");
                        txtAddressLine1.Value = DBUtility.readDBString(dr, "Address_Line_1");
                        txtAddressLine2.Value = DBUtility.readDBString(dr, "Address_Line_2");
                        txtPhone.Value = DBUtility.readDBString(dr, "telephone_1");
                        txtEmail.Value = DBUtility.readDBString(dr, "email");
                    }
                   
                }

                //set vehicle details
                if (Session["TRANSACTION_VEHICLES"] != null)
                {
                    var vehicles = (DataTable)Session["TRANSACTION_VEHICLES"];
                    if (vehicles != null && vehicles.Rows.Count > 0)
                    {
                        grdTransactionVehicles.DataSource = vehicles;
                        grdTransactionVehicles.DataBind();
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        #endregion 

        protected void btnNextTab_ServerClick(object sender, EventArgs e)
        {
            btnNextTab.HRef = "#pillstab1";
        }

     


      
     

        
    }
}