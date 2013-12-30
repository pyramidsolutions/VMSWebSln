<%@ Page Title="View Manufacturer" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="ViewManufacturer.aspx.cs" Inherits="MVSThemeTemplateWeb.ViewManufacturer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
     <form id="form2" runat="server" class="form-horizontal">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget purple" id="divCompanyData" runat="server">
                    <div class="widget-title">
                        <h4>Manufacturer Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>

                        </span>
                    </div>
                   
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdManufacturer" runat="server" AutoGenerateColumns="False" OnLoad="grdManufacturer_Load"  DataKeyNames="Manufacturer_ID">
                            <Columns>
                                  
                              
                                <asp:BoundField DataField="Manufacturer_Name" HeaderText="Name" SortExpression="Manufacturer_Name"></asp:BoundField>
                                <asp:BoundField DataField="Manufacturer_ID" HeaderText="Manufacturer_ID" SortExpression="Manufacturer_ID" InsertVisible="False" ReadOnly="True" Visible="false"></asp:BoundField>

                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
     

    </form>
</asp:Content>
