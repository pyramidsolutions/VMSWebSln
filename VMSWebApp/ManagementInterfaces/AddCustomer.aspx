<%@ Page Title="" Language="C#" MasterPageFile="~/ManagementInterfaces/Management.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="VMSWebApp.ManagementInterfaces.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" runat="server" id="DivAdd">
			<header class="clearfix">
				<span>Customers</span>
				<h1>Add Customer</h1>
				
			</header>
			
			<div class="main">
                <fieldset>
    <legend>Customer Details</legend>

    <ul>
      <li>
        <label for="Customer_name">Customer Name</label>
        <input type="text" name="Customer_name" id="Customer_name" placeholder="Customer Name" required="required" autofocus="autofocus" maxlength="20" />
      </li>

       <li>
        <label for="Address_Line_1">Address</label>
        <input type="text" name="Address_Line_1" id="Address_Line_1" placeholder="123 Example Street" required="required" autofocus="autofocus" maxlength="30" />
      </li>

      <li>
        <label for="Address_Line_2"></label>
        <input type="text" name="Address_Line_2" id="Address_Line_2" placeholder="" required="required" autofocus="autofocus" maxlength="30" />
      </li>

       <li>
        <label for="City">City</label>
        <input type="text" name="City" id="City" placeholder="e.g. Johannesburg" required="required" autofocus="autofocus" maxlength="20" />
      </li>

         <li>
        <label for="Code">Code</label>
        <input type="number"  name="Code" id="Code" placeholder="1234" required="required" autofocus="autofocus" maxlength="4" />
      </li>

       <li>
        <label for="telephone_1">Telephone 1</label>
        <input type="tel"   name="telephone_1" id="telephone_1" placeholder="0111231234" required="required" autofocus="autofocus" maxlength="13" />
      </li>

       <li>
        <label for="telephone_2">Telephone 2</label>
        <input type="tel"   name="telephone_2" id="telephone_2" placeholder="0111231234" required="required" autofocus="autofocus" maxlength="13" />
      </li>

        <li>
        <label for="Cellphone">Cellphone</label>
        <input type="tel"   name="Cellphone" id="Cellphone" placeholder="0821231234" required="required" autofocus="autofocus" maxlength="13" />
      </li>


         <li>
        <label for="fax">Fax</label>
        <input type="tel"   name="fax" id="fax" placeholder="0111231234" required="required" autofocus="autofocus" maxlength="13" />
      </li>

       <li>
        <label for="email">Email</label>
        <input type="email"   name="email" id="email" placeholder="example@email.com" required="required" autofocus="autofocus" maxlength="40" />
      </li>




      <li>
        <label for="wholesale_customer">Wholesale Customer</label>
        <input type="checkbox"  name="wholesale_customer" id="wholesale_customer" required="required"   />
      </li>
      
    </ul>

  </fieldset>
               
                    <asp:Button ID="submitbutton" runat="server" Text="Submit" CssClass="submitbutton" />
				
                     <asp:Button ID="cancelbutton" runat="server" Text="Cancel" CssClass="cancelbutton" />
                    
                    
               
			</div>
		</div>
</asp:Content>
