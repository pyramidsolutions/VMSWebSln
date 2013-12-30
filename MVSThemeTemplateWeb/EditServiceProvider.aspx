<%@ Page Title="Edit Service Provider" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditServiceProvider.aspx.cs" Inherits="MVSThemeTemplateWeb.EditServiceProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
       <form id="form2" runat="server" class="form-horizontal">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget yellow" id="divCompanyData" runat="server">
                    <div class="widget-title">
                        <h4>Service Provider Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>

                        </span>
                    </div>
                    <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Success!</h4>
                        <p>
                            The Service Provider has been updated succesfully
                        </p>
                    </div>
                    <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Error!</h4>
                        <p>
                            Please check the Form. The Service Provider has not been updated
                        </p>
                    </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdServiceProvider" runat="server" AutoGenerateColumns="False" OnLoad="grdServiceProvider_Load" OnRowCommand="grdServiceProvider_RowCommand" DataKeyNames="SP_ID"  >
                            <Columns>
                                     <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-success" ID = "button2" runat="server" CommandArgument='<%# Bind("SP_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="SP_Name" HeaderText="Name" SortExpression="SP_Name"></asp:BoundField>
                                 <asp:BoundField DataField="category" HeaderText="Category" SortExpression="category" Visible="false" />
                                <asp:BoundField DataField="SP_address" HeaderText="Address" SortExpression="SP_address"></asp:BoundField>

                                   <asp:BoundField DataField="Telephone" HeaderText="Telephone" SortExpression="Telephone" />

                                   <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" />
                                  
                                   <asp:BoundField DataField="SP_ID" HeaderText="SP_ID" InsertVisible="False" ReadOnly="True" SortExpression="SP_ID" Visible="false"/>

                                 <asp:BoundField DataField="ServiceProviderCategory_Name" HeaderText="Category" SortExpression="ServiceProviderCategory_Name" Visible="true"/>

                            </Columns>
                        </asp:GridView>

                        

                        

                        

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
  <div class="widget yellow">
            <div class="widget-title">
                <h4>Edit Service Provider</h4>
                <span class="tools">
                    <a href="javascript:;" class="icon-chevron-down"></a>

                </span>
            </div>
            <div class="widget-body">
                <!-- BEGIN FORM-->
                
                    <div class="control-group">
                        <label class="control-label">Name</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Service Provider Name" class="input-medium" id="txtServiceProviderName" />

                        </div>
                    </div>
                    <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtServiceProviderAddress" />

                            </div>
                        </div>
                     <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtServiceProviderTelephone" />
                            </div>
                        </div>
                    <div class="control-group">
                        <label class="control-label">Category</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Category" class="chzn-select-deselect span6"  id="lstCategory" runat="server">
                                
                            </select>
                        </div>
                    </div>

                     

                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxModelDisable" />
                            </div>
                        </div>
                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveServiceProvider" onserverclick="btnSaveServiceProvider_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelServiceProvider">Cancel</button>
                    </div>
           
                <!-- END FORM-->
            </div>
        </div>

    </form>
</asp:Content>
