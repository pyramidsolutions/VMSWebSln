<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCompany.aspx.cs" Inherits="VMSWebApp.ManagementInterfaces.AddCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainPH" runat="server">
    <fieldset>
    <legend>License details</legend>

    <ul>

      <li>
        <label for="emailAddress">Email address</label>
        <input type="email" name="emailAddress" id="emailAddress" placeholder="name@example.com" required="required" autofocus="autofocus" maxlength="50" />
      </li>

      <li>
        <label for="website">Website</label>
        <input type="url" name="website" id="website" placeholder="http://www.example.com/" required="required" maxlength="100" />
      </li>

      <li>
        <label for="numLicenses">Number of licenses</label>
        <input type="number" name="numLicenses" id="numLicenses" placeholder="How many to buy (1-10)" required="required" min="1" max="10" maxlength="2" />
      </li>
      
    </ul>

  </fieldset>
</asp:Content>
