<%@ Page Title="" Language="C#" MasterPageFile="~/ManagementInterfaces/Management.Master" AutoEventWireup="true" CodeBehind="AddVehicle.aspx.cs" Inherits="VMSWebApp.ManagementInterfaces.AddVehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <header class="clearfix">
            <span>Vehicle</span>
            <h1>Add Vehicle</h1>

        </header>

        <div class="main">
            <fieldset>
                <legend>Vehicle Details</legend>

                <ul>
                    <li>
                        <label for="Supplier_name">Supplier Name</label>
                        <select runat="server" name="Supplier_name" id="Supplier_name" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Manufacturer_Name">Manufacturer Name</label>
                        <select runat="server" name="Manufacturer_Name" id="Manufacturer_Name" required="required" autofocus="autofocus" />
                    </li>
                    <li>
                        <label for="Model_Name">Model Name</label>
                        <select runat="server" name="Model_Name" id="Model_Name" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Location_Name">Location</label>
                        <select runat="server" name="Location_Name" id="Location_Name" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Status">Status</label>
                        <select runat="server" name="Status" id="Status" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Colour">Colour</label>
                        <input type="text" runat="server" name="Colour" id="Colour" required="required" autofocus="autofocus" maxlength="20" />
                    </li>

                    <li>
                        <label for="Cost_Price">Cost Price</label>
                        <input type="number" name="Cost_Price" id="Cost_Price" placeholder="1000000" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Wholesale_Price">Wholesale Price</label>
                        <input type="number" name="Wholesale_Price" id="Wholesale_Price" placeholder="1000000" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Retail_Price">Retail Price</label>
                        <input type="number" name="Retail_Price" id="Retail_Price" placeholder="1000000" required="required" autofocus="autofocus" />
                    </li>

                    <li>
                        <label for="Registration_Number">Registration Number</label>
                        <input type="text" name="Registration_Number" id="Registration_Number" placeholder="ND 12345" required="required" autofocus="autofocus" maxlength="10" />
                    </li>

                    <li>
                        <label for="Engine_Number">Engine Number</label>
                        <input type="text" name="Engine_Number" id="Engine_Number" placeholder="J1234T56" required="required" autofocus="autofocus" maxlength="30" />
                    </li>

                    <li>
                        <label for="Vehicle_Register_Number">Vehicle Register Number</label>
                        <input type="text" name="Vehicle_Register_Number" id="Vehicle_Register_Number" placeholder="JTK2000" required="required" autofocus="autofocus" maxlength="10" />
                    </li>

                    <li>
                        <label for="Chassis_Number">Chasis Number</label>
                        <input type="text" name="Chassis_Number" id="Chassis_Number" placeholder="AAVZZZ1234" required="required" maxlength="30" />
                    </li>

                    <li>
                        <label for="Mileage">Mileage</label>
                        <input type="number" name="Mileage" id="Mileage" placeholder="1234" required="required" />
                    </li>

                    <li>
                        <label for="Automatic_Transmission">Transmission</label>
                        <select name="Automatic_Transmission" id="Automatic_Transmission" required="required" />
                    </li>

                    <li>
                        <label for="Picture_1">Picture 1</label>
                        <input type="file" name="Picture_1" id="Picture_1" class="image"   />
                        
                        
                    </li>

                    <li>
                        <label for="Picture_2">Picture 2</label>
                        <input type="file" name="Picture_2" id="Picture_2" class="image"   />
                        
                        
                    </li>
                   
                    <li>
                        <label for="Picture_3">Picture 3</label>
                        <input type="file" name="Picture_3" id="Picture_3" class="image"   />
                        
                        
                    </li>
                </ul>

            </fieldset>
            
            <asp:Button ID="submitbutton" runat="server" Text="Submit" CssClass="submitbutton" />

            <asp:Button ID="cancelbutton" runat="server" Text="Cancel" CssClass="cancelbutton" />



        </div>
    </div>
</asp:Content>
