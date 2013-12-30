<%@ Page Title="Edit Customer" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="MVSThemeTemplateWeb.EditCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form2" runat="server" class="form-horizontal">
     <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget red" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Customer Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                           
                        </span>
                    </div>
                      <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Customer has been updated succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The customer has not been updated
                </p>
            </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdCustomer" runat="server" AutoGenerateColumns="False" OnLoad="grdCustomer_Load" OnRowCommand="grdCustomer_RowCommand" DataKeyNames="Customer_Code"  >
                            <Columns>
                                   <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-success" ID = "button2" runat="server" CommandArgument='<%# Bind("Customer_Code") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                 <asp:BoundField DataField="Customer_name" HeaderText="Name" SortExpression="Customer_name" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_1" HeaderText="Address_Line_1" SortExpression="Address_Line_1" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_2" HeaderText="Address_Line_2" SortExpression="Address_Line_2" Visible="false"  >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_1" HeaderText="Telephone" SortExpression="telephone_1" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_2" HeaderText="telephone_2" SortExpression="telephone_2" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Cellphone" HeaderText="Cell" SortExpression="Cellphone" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="wholesale_customer" HeaderText="Wholesale" SortExpression="wholesale_customer" >
                                    
                                </asp:CheckBoxField>

                                <asp:BoundField DataField="VAT_number" HeaderText="VAT_number" SortExpression="VAT_number" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Representative" HeaderText="Representative" SortExpression="Representative" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="CK_number" HeaderText="CK_number" SortExpression="CK_number" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>
                                <asp:BoundField DataField="Customer_Code" HeaderText="Customer_Code" SortExpression="Customer_Code" InsertVisible="False" ReadOnly="True" Visible="false">
                                    
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>



                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
      <div class="row-fluid">
        
            
            <div class="widget green">
                <div class="widget-title">
                    <h4>Edit Customer</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->
                    
                        <div class="control-group">
                            <label class="control-label">Customer Name</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Customer Name" class="input-medium" id="txtCustomerName" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtCustomerAddress" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address Line 2</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address Line 2" class="input-large" id="txtCustomerAddressLine2" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">City</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="City" class="input-medium" id="txtCustomerCity" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Code</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Code" class="input-small" id="txtCustomerCode" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtCustomerTelephone" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone 2</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231235" id="txtCustomerTelephone2" />

                            </div>
                        </div>
                         <div class="control-group">
                            <label class="control-label">Cellphone</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0821231235" id="txtCustomerCellphone" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Fax</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231236" id="txtCustomerFax" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Email</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="email" placeholder="example@mail.com" id="txtCustomerEmail" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Wholesale Customer</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkCustomerWholesaleCustomer" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">VAT Number</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="text" placeholder="WXYX1234" id="txtCustomerVATNumber" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">Representative</label>
                            <div class="controls">
                                <input class="input-large" runat="server" type="number" id="txtCustomerRepresentative" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">CK Number</label>
                            <div class="controls">
                                <input class="input-large" runat="server" type="text"  id="txtCustomerCKNumber" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxCustomerDisable" />
                            </div>
                        </div>

                        <div class="form-actions">
                            <button type="submit" runat="server" class="btn btn-success" id="btnSaveCompany" onserverclick="btnSaveCompany_ServerClick" >Save</button>
                            <button type="button" runat="server" class="btn" id="btnCancelCompany">Cancel</button>
                        </div>
                    
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    
    </form>
</asp:Content>
