<%@ Page Title="View Service Provider" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="ViewServiceProvider.aspx.cs" Inherits="MVSThemeTemplateWeb.ViewServiceProvider" %>
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
                   
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdServiceProvider" runat="server" AutoGenerateColumns="False" OnLoad="grdServiceProvider_Load" OnRowCommand="grdServiceProvider_RowCommand" DataKeyNames="SP_ID"  >
                            <Columns>
                                    
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


    </form>
</asp:Content>
