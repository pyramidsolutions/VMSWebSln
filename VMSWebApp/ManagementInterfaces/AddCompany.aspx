<%@ Page Title="" Language="C#" MasterPageFile="~/ManagementInterfaces/Management.Master" AutoEventWireup="true" CodeBehind="AddCompany.aspx.cs" Inherits="VMSWebApp.ManagementInterfaces.AddCompany1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
			<header class="clearfix">
				<span>Company</span>
				<h1>Add Company</h1>
				
			</header>
			
			<div class="main">
                <fieldset>
    <legend>Company Details</legend>

    <ul>
      <li>
        <label for="Company_name">Company Name</label>
        <input type="text" name="Company_name" id="Company_name" placeholder="Company Name" required="required" autofocus="autofocus" maxlength="20" />
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
        <label for="fax">Fax</label>
        <input type="tel"   name="fax" id="fax" placeholder="0111231234" required="required" autofocus="autofocus" maxlength="13" />
      </li>

       <li>
        <label for="email">Email</label>
        <input type="email"   name="email" id="email" placeholder="example@email.com" required="required" autofocus="autofocus" maxlength="40" />
      </li>



      <li>
        <label for="website">Website</label>
        <input type="url" name="website" id="website" placeholder="http://www.example.com/" required="required" maxlength="100" />
      </li>

      <li>
        <label for="VAT_number">VAT Number</label>
        <input type="text" name="VAT_number" id="VAT_number" placeholder="e.g. VZ1234R" required="required"  maxlength="15" />
      </li>
      
    </ul>

  </fieldset>
               
                    <asp:Button ID="submitbutton" runat="server" Text="Submit" CssClass="submitbutton" />
				
                     <asp:Button ID="cancelbutton" runat="server" Text="Cancel" CssClass="cancelbutton" />
                    
                    
               
			</div>
		</div>
</asp:Content>
