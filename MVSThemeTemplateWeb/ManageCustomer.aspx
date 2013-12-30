<%@ Page Title="" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="MVSThemeTemplateWeb.ManageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form1" runat="server">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget blue" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Customers Table</h4>
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
                    Please check the Form. The Customer has not been updated
                </p>
            </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdCompany" runat="server" AutoGenerateColumns="False" OnLoad="grdCompany_Load" OnRowCommand="grdCompany_RowCommand" AllowPaging="True">
                            <Columns>
                                 <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-success" ID = "button2" runat="server" CommandArgument='<%# Bind("Company_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:BoundField DataField="Customer_name" HeaderText="Name" SortExpression="Customer_name" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_1" HeaderText="Address" SortExpression="Address_Line_1" visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Address_Line_2" HeaderText="Address Line 2" SortExpression="Address_Line_2" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"   >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_1" HeaderText="Tel" SortExpression="telephone_1"  >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="telephone_2" HeaderText="telephone_2" SortExpression="telephone_2" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Cellphone" HeaderText="Cell" SortExpression="Cellphone"  Visible="true">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" Visible="true">
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="wholesale_customer" HeaderText="Wholesale" SortExpression="wholesale_customer" Visible="true">
                                    
                                </asp:CheckBoxField>

                                <asp:BoundField DataField="VAT_number" HeaderText="VAT_number" SortExpression="VAT_number" Visible="False">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="Representative" HeaderText="Representative" SortExpression="Representative" Visible="false">
                                    
                                </asp:BoundField>
                                <asp:BoundField DataField="CK_number" HeaderText="CK_number" SortExpression="CK_number" Visible="false" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>

                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>

     
    </form>
</asp:Content>
