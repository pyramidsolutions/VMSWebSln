<%@ Page Title="Edit Company" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditCompany.aspx.cs" Inherits="MVSThemeTemplateWeb.EditCompany" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form1" runat="server" class="form-horizontal">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget red" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Company Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                           
                        </span>
                    </div>
                      <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Company has been updated succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The company has not been updated
                </p>
            </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdCompany" runat="server" AutoGenerateColumns="False" OnLoad="grdCompany_Load" OnRowCommand="grdCompany_RowCommand">
                            <Columns>
                                <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-success" ID = "button2" runat="server" CommandArgument='<%# Bind("Company_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                 <asp:BoundField DataField="Company_ID" HeaderText="Company_ID" SortExpression="Company_ID"  Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Company_name" HeaderText="Name" SortExpression="Company_name" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_1" HeaderText="Address_Line_1" SortExpression="Address_Line_1" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_2" HeaderText="Address_Line_2" SortExpression="Address_Line_2" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_1" HeaderText="Telephone" SortExpression="telephone_1" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_2" HeaderText="telephone_2" SortExpression="telephone_2" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="website" HeaderText="website" SortExpression="website" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="VAT_number" HeaderText="VAT_number" SortExpression="VAT_number" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="VAT_percentage" HeaderText="VAT_percentage" SortExpression="VAT_percentage" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Invoice_Footer" HeaderText="Invoice_Footer" SortExpression="Invoice_Footer" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>
                                <asp:CheckBoxField DataField="ForceMonthend" HeaderText="ForceMonthend" SortExpression="ForceMonthend" Visible="false" >
                                    
                                </asp:CheckBoxField>

                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>

           <div class="row-fluid">
        <div class="span12">
            <!-- BEGIN SAMPLE FORMPORTLET-->
            <div class="widget green">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>Edit Company</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                        
                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->
                    
                        <div class="control-group">
                            <label class="control-label">Company Name</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Company Name" class="input-medium" id="txtCompanyName" />
                               
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtCompanyAddress" />
                                
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address Line 2</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address Line 2" class="input-large" id="txtCompanyAddressLine2" />
                                
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">City</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="City" class="input-medium" id="txtCompanyCity" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Code</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Code" class="input-small" id="txtCompanyCode" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtCompanyTelephone"/>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone 2</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231235" id="txtCompanyTelephone2" />
                               
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Fax</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231236" id="txtCompanyFax" />
                            </div>
                        </div>
                          <div class="control-group">
                            <label class="control-label">Email</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="email" placeholder="example@mail.com" id="txtCompanyEmail" />
                            </div>
                        </div>
                          <div class="control-group">
                            <label class="control-label">Website</label>
                            <div class="controls">
                                <input class="input-medium" runat="server"  type="text" placeholder="www.company.com" id="txtCompanyWebsite" />
                            </div>
                         </div>
                                <div class="control-group">
                            <label class="control-label">VAT Number</label>
                            <div class="controls">
                                <input class="input-medium" runat="server"  type="text" placeholder="WXYX1234" id="txtCompanyVATNumbwer" />
                            </div>
                        </div>
                        
                          <div class="control-group">
                            <label class="control-label">VAT Percentage</label>
                            <div class="controls">
                                <input class="input-mini" runat="server" type="number" id="txtCompanyVATPercentage"  />
                            </div>
                        </div>

                          <div class="control-group">
                            <label class="control-label">Company Logo</label>
                            <div class="controls">
                                <input class="input-xxlarge" runat="server" type="file"  id="fileUplaodCompanyLogo" />
                            </div>
                        </div>
                          <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox"  id="chkBoxCompanyDisable" />
                            </div>
                        </div>
                       
                        <div class="form-actions">
                            <button type="submit" runat="server" class="btn btn-success" id="btnSaveCompany" onserverclick="btnSaveCompany_ServerClick"> Save</button>
                            <button type="button" runat="server" class="btn" id="btnCancelCompany"> Cancel</button>
                        </div>
                    
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    </div> 
    </form>
</asp:Content>
