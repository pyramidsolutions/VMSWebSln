<%@ Page Title="View Location" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="ViewLocation.aspx.cs" Inherits="MVSThemeTemplateWeb.ViewLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form2" runat="server" class="form-horizontal">
     <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget grey" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Improvement Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                           
                        </span>
                    </div>
                     
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdLocation" runat="server" AutoGenerateColumns="False" OnLoad="grdLocation_Load" OnRowCommand="grdLocation_RowCommand" DataKeyNames="Location_ID"  >
                            <Columns>
                                      <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-edit" ID = "button2" runat="server" CommandArgument='<%# Bind("Location_ID") %>' CommandName="ViewRow" Text="View" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:BoundField DataField="Location_Name" HeaderText="Name" SortExpression="Location_Name" >
                                    
                                </asp:BoundField>
                                 <asp:BoundField DataField="Location_Description" HeaderText="Description" SortExpression="Location_Description" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>

                                
                                <asp:BoundField DataField="Location_ID" HeaderText="Location_ID" SortExpression="Location_ID" InsertVisible="False" ReadOnly="True" Visible="false"  >
                                    
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>



                    



                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
      <div class="row-fluid">
        
            
            <div class="widget grey">
                <div class="widget-title">
                    <h4>View Location</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->
                    
                        <div class="control-group">
                            <label class="control-label">Name</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Customer Name" class="input-medium" id="txtLocationName" readonly="true"/>

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Description</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtLocationDescription" readonly="true"/>

                            </div>
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxLocationDisable" disabled="disabled"/>
                            </div>
                        </div>

                        <div class="form-actions">
                            
                            <button type="button" runat="server" class="btn" id="btnCancelCompany">Cancel</button>
                        </div>
                    
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    
    </form>
</asp:Content>
