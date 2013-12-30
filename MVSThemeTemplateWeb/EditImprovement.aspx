<%@ Page Title="Edit Improvement" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditImprovement.aspx.cs" Inherits="MVSThemeTemplateWeb.EditImprovement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
     <form id="form2" runat="server" class="form-horizontal">
     <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget green" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Improvement Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                           
                        </span>
                    </div>
                      <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Improvement has been updated succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The Improvement has not been updated
                </p>
            </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdCustomer" runat="server" AutoGenerateColumns="False" OnLoad="grdCustomer_Load" OnRowCommand="grdCustomer_RowCommand" DataSourceID="SqlDataSource1"  >
                            <Columns>
                                
                                 <asp:BoundField DataField="SP_ID" HeaderText="SP_ID" SortExpression="SP_ID" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Stock_Code" HeaderText="Stock_Code" SortExpression="Stock_Code" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Improvement_Description" HeaderText="Improvement_Description" SortExpression="Improvement_Description"  >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Improvement_price" HeaderText="Improvement_price" SortExpression="Improvement_price" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Improvement_Name" HeaderText="Improvement_Name" SortExpression="Improvement_Name">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="SP_Name" HeaderText="SP_Name" SortExpression="SP_Name" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Expr1" HeaderText="Expr1" SortExpression="Expr1" InsertVisible="False" ReadOnly="True" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>

                                <asp:BoundField DataField="Improvement_ID" HeaderText="Improvement_ID" SortExpression="Improvement_ID" InsertVisible="False" ReadOnly="True" >
                                    
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>



                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MVSSqlDev2008ConnectionString %>" SelectCommand="sp_GetAllImprovements" SelectCommandType="StoredProcedure"></asp:SqlDataSource>



                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
      <div class="row-fluid">
        
            
            <div class="widget green">
                <div class="widget-title">
                    <h4>Edit Improvement</h4>
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
