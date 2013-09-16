<%@ Page Title="" Language="C#" MasterPageFile="~/ManagementInterfaces/Management.Master" AutoEventWireup="true" CodeBehind="ManageCustomers.aspx.cs" Inherits="VMSWebApp.ManagementInterfaces.ManageCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server" id="divListCustomers">
			<header class="clearfix">
				<span>Customers</span>	
			</header>
			<asp:Repeater ID="repeaterCustomer" runat="server">

        <ItemTemplate>
            <table>
                <tr>
                    <td>Name</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Customer_name") %> </td>
                    <td>Telephone 1</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "telephone_1") %> </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Address_Line_1") %> </td>
                    <td>Telephone 2</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "telephone_2") %> </td>
                </tr>
                <tr>
                    <td></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Address_Line_2") %> </td>
                    <td>Cellphone</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Cellphone") %> </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "City") %> </td>
                    <td>Fax</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "fax") %> </td>
                </tr>
                <tr>
                    <td>Code </td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Code") %> </td>
                    <td>Email</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "email") %> </td>
                </tr>
                <tr>
                    <td>Wholesale Customer</td>
                    <td><%# DataBinder.Eval(Container.DataItem, "wholesale_customer") %> </td>

                </tr>

            </table>
        </ItemTemplate>
			</asp:Repeater>
		
		</div>
   
</asp:Content>
