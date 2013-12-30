<%@ Page Title="Add Vehicle Transaction" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddVehicleTransaction.aspx.cs" Inherits="MVSThemeTemplateWeb.AddVehicleTransaction" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form runat="server" class="form-horizontal">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="row-fluid">
            <div class="span12">
                <div class="widget box green">
                    <div class="widget-title">
                        <h4>Add Transaction Wizard</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down">

                            </a>
                        </span>
                    </div>
                    <div class="widget-body">
                        <div id="pills" class="custom-wizard-pills">
                          
                            <div class="progress progress-success progress-striped active">
                                <div class="bar">

                                </div>
                            </div>
                           

                                <asp:MultiView ID="multiViewAddTransaction" runat="server" ActiveViewIndex="0" OnLoad="multiViewAddTransaction_Load">
                                    
                                    <asp:View ID="viewAddVehicleTransactions" runat="server" >
                                      
                                            <div class="tab-pane" id="pills-tab1" >
                                            <h3>Vehicles for the Transaction</h3>
                                            <div class="control-group">

                                                <label class="control-label">Search</label>
                                                <div class="controls">
                                                    <input type="text" class="span6" runat="server" id="txtSearchVehicles" />
                                                    <button type="button" runat="server" id="btnSearch" class="btn blue" onserverclick="btnSearch_ServerClick"><i class="icon-search"></i>Search</button>

                                                </div>
                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <div class="alert alert-info" runat="server" id="nothingFound" visible="false">
                                                            <button class="close" data-dismiss="alert">×</button>
                                                            <strong>Info!</strong> No Vehicles Found
                                                        </div>
                                                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdTransactionVehicles" runat="server" AutoGenerateColumns="False" DataKeyNames="Stock_Code" GridLines="Vertical" EnableViewState="true">

                                                            <Columns>


                                                                <asp:BoundField DataField="VehicleName" HeaderText="Name" ReadOnly="True" SortExpression="VehicleName" />
                                                                <asp:BoundField DataField="Retail_Price" HeaderText="Retail Price" SortExpression="Retail_Price" DataFormatString="{0:c}" />
                                                                <asp:BoundField DataField="Wholesale_Price" HeaderText="Wholesale Price" SortExpression="Wholesale_Price" DataFormatString="{0:c}" />
                                                                <asp:BoundField DataField="Colour" HeaderText="Colour" SortExpression="Colour" />
                                                                <asp:BoundField DataField="Arrival_Date" HeaderText="Arrival Date" SortExpression="Arrival_Date" DataFormatString="{0:d}" Visible="false" />
                                                                <asp:BoundField DataField="Vehicle_Status" HeaderText="Vehicle Status" SortExpression="Vehicle_Status" Visible="false" />
                                                                <asp:BoundField DataField="Stock_Code" HeaderText="Stock_Code" InsertVisible="False" ReadOnly="True" SortExpression="Stock_Code" Visible="false" />
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <asp:HiddenField ID="hdnStock_Id" runat="server" ViewStateMode="Enabled" Value='<%# Bind("Stock_Code") %>' EnableViewState="true" />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>

                                                        </asp:GridView>
                                                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdVehicles" runat="server" AutoGenerateColumns="False" DataKeyNames="Stock_Code" OnRowCreated="grdVehicles_RowCreated" AllowPaging="True" GridLines="Vertical" OnRowCommand="grdVehicles_RowCommand" EnableViewState="true" OnRowDataBound="grdVehicles_RowDataBound" OnPageIndexChanging="grdVehicles_PageIndexChanging" PageSize="5">

                                                            <Columns>

                                                                <asp:TemplateField>
                                                                    <HeaderTemplate>
                                                                        Select
                                                                    </HeaderTemplate>
                                                                    <ItemStyle />
                                                                    <ItemTemplate>
                                                                        <asp:Button class="edit" ID="btnAddtoTransaction" runat="server" onserverclick="btnAddtoTransaction_ServerClick" Text="+" CommandArgument='<%# Bind("Stock_Code") %>' CommandName="AddVehicle"></asp:Button>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField>

                                                                    <ItemTemplate>
                                                                        <asp:Image runat="server" ID="vehicleImage" ImageUrl="~/img/404bg.jpg" Width="100px" Height="100px" />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:BoundField DataField="VehicleName" HeaderText="Name" ReadOnly="True" SortExpression="VehicleName" />
                                                                <asp:BoundField DataField="Retail_Price" HeaderText="Retail Price" SortExpression="Retail_Price" DataFormatString="{0:c}" />
                                                                <asp:BoundField DataField="Wholesale_Price" HeaderText="Wholesale Price" SortExpression="Wholesale_Price" DataFormatString="{0:c}" />
                                                                <asp:BoundField DataField="Colour" HeaderText="Colour" SortExpression="Colour" />
                                                                <asp:BoundField DataField="Arrival_Date" HeaderText="Arrival Date" SortExpression="Arrival_Date" DataFormatString="{0:d}" />
                                                                <asp:BoundField DataField="Vehicle_Status" HeaderText="Vehicle Status" SortExpression="Vehicle_Status" Visible="false" />
                                                                <asp:BoundField DataField="Stock_Code" HeaderText="Stock_Code" InsertVisible="False" ReadOnly="True" SortExpression="Stock_Code" Visible="false" />
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <asp:HiddenField ID="hdnStock_Id" runat="server" ViewStateMode="Enabled" Value='<%# Bind("Stock_Code") %>' EnableViewState="true" />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>

                                                        </asp:GridView>

                                                    </ContentTemplate>
                                                    <Triggers>

                                                        <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="ServerClick" />

                                                    </Triggers>
                                                </asp:UpdatePanel>
                                            </div>

                                        </div>
                                      
                                       
                                    </asp:View>

                                    <asp:View ID="viewCustomerInformation" runat="server">

                                     
                                              <div class="tab-pane" id="pills-tab2">
                                            <h3>Customer Details for Transaction</h3>
                                            <div class="control-group">
                                                <label class="control-label">Customer Search</label>
                                                <div class="controls">
                                                    <input type="text" class="span6" runat="server" id="txtSearchCustomers" />
                                                    <button type="button" runat="server" id="btnSearchCustomers" class="btn blue" onserverclick="btnSearchCustomers_ServerClick"><i class="icon-search"></i>Search</button>
                                                    <span class="help-inline">Search for Customers by First Name or Last Name</span>
                                                </div>
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <div class="alert alert-info" runat="server" id="divCustomersNothingFound" visible="false">
                                                        <button class="close" data-dismiss="alert">×</button>
                                                        <strong>Info!</strong> No Customers Found
                                                    </div>
                                                    <asp:GridView CssClass="table table-striped table-bordered" ID="grdCustomers" runat="server" AutoGenerateColumns="False" DataKeyNames="Customer_Code" GridLines="Vertical" OnPageIndexChanging="grdCustomers_PageIndexChanging" PageSize="10" OnSelectedIndexChanged="grdCustomers_SelectedIndexChanged" OnRowDataBound="grdCustomers_RowDataBound">

                                                        <Columns>


                                                            <asp:BoundField DataField="Customer_Code" HeaderText="Customer_Code" ReadOnly="True" SortExpression="Customer_Code" InsertVisible="False" Visible="false" />
                                                            <asp:BoundField DataField="Customer_name" HeaderText="Name" SortExpression="Customer_name" />
                                                            <asp:BoundField DataField="Address_Line_1" HeaderText="Address" SortExpression="Address_Line_1" />
                                                            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                                            <asp:BoundField DataField="telephone_1" HeaderText="Tel" SortExpression="telephone_1" />
                                                            <asp:CheckBoxField DataField="wholesale_customer" HeaderText="Wholesale" SortExpression="wholesale_customer" />
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <asp:HiddenField ID="hdnCustomer_Id" runat="server" ViewStateMode="Enabled" Value='<%# Bind("Customer_Code") %>' EnableViewState="true" />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>

                                                    </asp:GridView>




                                                </ContentTemplate>
                                                <Triggers>

                                                    <asp:AsyncPostBackTrigger ControlID="btnSearchCustomers" EventName="ServerClick" />

                                                </Triggers>
                                            </asp:UpdatePanel>
                                        </div>

                                  
                                      
                                    </asp:View>

                                    <asp:View ID="viewCreateInvoice" runat="server">
                                       
                                        <div class="tab-pane" id="pills-tab3">
                                            <h3>Create Invoice</h3>


                                            <div class="row-fluid">
                                                <div class="span12">
                                                    <!-- BEGIN BLANK PAGE PORTLET-->
                                                    <div class="widget purple">
                                                        <div class="widget-title">
                                                            <h4><i class="icon-edit"></i>Create Invoice </h4>
                                                            <span class="tools">
                                                                <a href="javascript:;" class="icon-chevron-down"></a>
                                                                <a href="javascript:;" class="icon-remove"></a>
                                                            </span>
                                                        </div>
                                                        <div class="widget-body">
                                                            <div class="portlet-body">
                                                                <div class="invoice-date-range span12 form">
                                                                    <h4>Invoice Info</h4>

                                                                    <div class="control-group ">
                                                                        <label class="control-label">In Date</label>
                                                                        <input type="text" placeholder="" data-mask="99/99/9999" runat="server" id="txtDate" readonly="readonly" />

                                                                        <label class="control-label">Status</label>
                                                                        <select runat="server" id="drpStatus">
                                                                            <option>Paid</option>
                                                                            <option>Due</option>
                                                                        </select>
                                                                    </div>

                                                                </div>
                                                                <div class="space15"></div>
                                                                <div class="row-fluid">
                                                                    <div class="span6 billing-form">
                                                                        <h4>Billing Address</h4>
                                                                        <div class="space10"></div>

                                                                        <div class="control-group ">
                                                                            <label class="control-label">Customer Name</label>
                                                                            <input type="text" value="" size="16" class=" span8" runat="server" id="txtCustomerName" readonly="readonly" />
                                                                        </div>
                                                                        <div class="control-group ">
                                                                            <label class="control-label">Address</label>
                                                                            <input type="text" value="" size="16" class=" span8" runat="server" readonly="readonly" id="txtAddressLine1" />

                                                                        </div>
                                                                        <div class="control-group ">
                                                                            <label class="control-label">Address Line 2</label>
                                                                            <input type="text" value="" size="16" class=" span8" runat="server" readonly="readonly" id="txtAddressLine2" />
                                                                        </div>
                                                                        <div class="control-group ">
                                                                            <label class="control-label">Phone</label>
                                                                            <input type="text" value="" size="16" class=" span8" runat="server" readonly="readonly" id="txtPhone" />
                                                                        </div>
                                                                        <div class="control-group ">
                                                                            <label class="control-label">Email</label>
                                                                            <input type="text" value="" size="16" class=" span8" runat="server" readonly="readonly" id="txtEmail" />
                                                                        </div>



                                                                    </div>


                                                                </div>
                                                                <div class="space15"></div>
                                                                <div class="row-fluid">
                                                                    <div class="span12">
                                                                        <h4>Vehicle Details</h4>
                                                                        <asp:GridView HeaderStyle-BorderColor="White" CssClass="table table-striped table-bordered" ID="grdInvoiceVehicles" runat="server" AutoGenerateColumns="False" DataKeyNames="Stock_Code" EnableViewState="true">

                                                                            <Columns>

                                                                                <asp:BoundField DataField="Stock_Code" HeaderText="Stock Code" InsertVisible="False" ReadOnly="True" SortExpression="Stock_Code" Visible="true" />
                                                                                <asp:BoundField DataField="VehicleName" HeaderText="Name" ReadOnly="True" SortExpression="VehicleName" />
                                                                                <asp:BoundField DataField="Retail_Price" HeaderText="Retail Price" SortExpression="Retail_Price" DataFormatString="{0:c}" />
                                                                                <asp:BoundField DataField="Wholesale_Price" HeaderText="Wholesale Price" SortExpression="Wholesale_Price" DataFormatString="{0:c}" />
                                                                                <asp:BoundField DataField="Colour" HeaderText="Colour" SortExpression="Colour" />
                                                                                <asp:BoundField DataField="Arrival_Date" HeaderText="Arrival Date" SortExpression="Arrival_Date" DataFormatString="{0:d}" Visible="false" />
                                                                                <asp:BoundField DataField="Vehicle_Status" HeaderText="Vehicle Status" SortExpression="Vehicle_Status" Visible="false" />
                                                                                <asp:TemplateField>
                                                                                    <ItemTemplate>
                                                                                        <asp:HiddenField ID="hdnStock_Id" runat="server" ViewStateMode="Enabled" Value='<%# Bind("Stock_Code") %>' EnableViewState="true" />
                                                                                    </ItemTemplate>
                                                                                </asp:TemplateField>
                                                                            </Columns>

                                                                        </asp:GridView>
                                                                        <div class="row-fluid text-center">
                                                                            <a class="btn btn-primary btn-large hidden-print" id="btnSubmitInvoice" runat="server" onserverclick="btnSubmitInvoice_ServerClick">Submit Invoice </a>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <!-- END BLANK PAGE PORTLET-->
                                                </div>
                                            </div>
                                        </div>
                                    
                                    </asp:View>

                                    <asp:View ID="viewPrintInvoice" runat="server">

                                        <div class="tab-pane" id="Div1">



                                            <div class="row-fluid">
                                                <div class="span12">
                                                    <!-- BEGIN BLANK PAGE PORTLET-->
                                                    <div class="widget purple">
                                                        <div class="widget-title">
                                                            <h4><i class="icon-edit"></i>Invoice Page </h4>
                                                            <span class="tools">
                                                                <a href="javascript:;" class="icon-chevron-down"></a>
                                                                <a href="javascript:;" class="icon-remove"></a>
                                                            </span>
                                                        </div>
                                                        <div class="widget-body">
                                                            <div class="row-fluid">
                                                                <div class="span12">
                                                                    <div class="text-center">
                                                                        <img alt="" src="img/vector-lab.jpg" />
                                                                    </div>
                                                                    <hr/>
                                                                </div>
                                                            </div>
                                                            <div class="space20"></div>
                                                            <div class="row-fluid invoice-list">
                                                                <div class="span4">
                                                                    <h4>BILLING ADDRESS</h4>
                                                                    <p>
                                                                        Jonathan Smith
                                                                        <br>
                                                                        44 Dreamland Tower, Suite 566
                                                                        <br>
                                                                        ABC, Dreamland 1230<br>
                                                                        Tel: +12 (012) 345-67-89
                                                                    </p>
                                                                </div>
                                                                <div class="span4">
                                                                    <h4>SHIPPING ADDRESS</h4>
                                                                    <p>
                                                                        Vector Lab<br>
                                                                        Road 1, House 2, Sector 3<br>
                                                                        ABC, Dreamland 1230<br>
                                                                        P: +38 (123) 456-7890<br>
                                                                    </p>
                                                                </div>
                                                                <div class="span4">
                                                                    <h4>INVOICE INFO</h4>
                                                                    <ul class="unstyled">
                                                                        <li>Invoice Number		: <strong>69626</strong></li>
                                                                        <li>Invoice Date		: 2013-03-17</li>
                                                                        <li>Due Date			: 2013-03-20</li>
                                                                        <li>Invoice Status		: Paid</li>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                            <div class="space20"></div>
                                                            <div class="space20"></div>
                                                            <div class="row-fluid">
                                                                <table class="table table-striped table-hover">
                                                                    <thead>
                                                                        <tr>
                                                                            <th>#</th>
                                                                            <th>Item</th>
                                                                            <th class="hidden-480">Description</th>
                                                                            <th class="hidden-480">Unit Cost</th>
                                                                            <th class="hidden-480">Quantity</th>
                                                                            <th>Total</th>
                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td>1</td>
                                                                            <td>LCD Monitor</td>
                                                                            <td class="hidden-480">20 inch Philips LCD Black color monitor</td>
                                                                            <td class="hidden-480">$ 1000</td>
                                                                            <td class="hidden-480">2</td>
                                                                            <td>$ 2000</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>2</td>
                                                                            <td>Laptop</td>
                                                                            <td class="hidden-480">Apple Mac book pro 15” Retina Display. 2.8 GHz Processor,8 GB Ram</td>
                                                                            <td class="hidden-480">$1750</td>
                                                                            <td class="hidden-480">1</td>
                                                                            <td>$1750</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>3</td>
                                                                            <td>Mouse</td>
                                                                            <td class="hidden-480">Apple Magic Mouse</td>
                                                                            <td class="hidden-480">$90</td>
                                                                            <td class="hidden-480">3</td>
                                                                            <td>$270</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>4</td>
                                                                            <td>Personal Computer</td>
                                                                            <td class="hidden-480">iMac 21 inch slim body. 1.7 GHz, 8 GB Ram</td>
                                                                            <td class="hidden-480">$1200</td>
                                                                            <td class="hidden-480">2</td>
                                                                            <td>$2400</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>5</td>
                                                                            <td>Printer</td>
                                                                            <td class="hidden-480">Epson Color Jet printer </td>
                                                                            <td class="hidden-480">$200</td>
                                                                            <td class="hidden-480">2</td>
                                                                            <td>$400</td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </div>
                                                            <div class="space20"></div>
                                                            <div class="row-fluid">
                                                                <div class="span4 invoice-block pull-right">
                                                                    <ul class="unstyled amounts">
                                                                        <li><strong>Sub - Total amount :</strong> $6820</li>
                                                                        <li><strong>Discount :</strong> 10%</li>
                                                                        <li><strong>VAT :</strong> -----</li>
                                                                        <li><strong>Grand Total :</strong> $6138</li>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                            <div class="space20"></div>
                                                            <div class="row-fluid text-center">
                                                                <a class="btn btn-success btn-large hidden-print">Submit Your Invoice <i class="icon-check"></i></a>
                                                                <a class="btn btn-inverse btn-large hidden-print" onclick="javascript:window.print();">Print <i class="icon-print icon-big"></i></a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <!-- END BLANK PAGE PORTLET-->
                                                </div>
                                            </div>
                                        </div>

                                    </asp:View>
                                    
                                </asp:MultiView>

                                 

                                
                                
                                <ul class="pager wizard">
                                    
                                    <li class="previous"><a runat="server" id="btnPrevTab" onserverclick="btnPrevTab_ServerClick">Previous</a></li>
                                   
                                    <li class="next"><a  runat="server" id="btnNextTab" onserverclick="btnNextTab_ServerClick">Next</a></li>
                                </ul>
                            </div>
                

                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
