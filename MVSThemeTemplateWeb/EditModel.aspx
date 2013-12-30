<%@ Page Title="Edit Model" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditModel.aspx.cs" Inherits="MVSThemeTemplateWeb.EditModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
       <form id="form2" runat="server" class="form-horizontal">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget red" id="divCompanyData" runat="server">
                    <div class="widget-title">
                        <h4>Model Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>

                        </span>
                    </div>
                    <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Success!</h4>
                        <p>
                            The Model has been updated succesfully
                        </p>
                    </div>
                    <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Error!</h4>
                        <p>
                            Please check the Form. The Model has not been updated
                        </p>
                    </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdModel" runat="server" AutoGenerateColumns="False" OnLoad="grdModel_Load" OnRowCommand="grdModel_RowCommand" DataKeyNames="Model_ID"  >
                            <Columns>
                                 <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-success" ID = "button2" runat="server" CommandArgument='<%# Bind("Model_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Model_Name" HeaderText="Name" SortExpression="Model_Name"></asp:BoundField>
                                 <asp:BoundField DataField="Manufacturer_Name" HeaderText="Manufacturer" SortExpression="Manufacturer_Name" />
                                <asp:BoundField DataField="VehicleType_Name" HeaderText="Vehicle Type" SortExpression="VehicleType_Name"></asp:BoundField>

                                   <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" />
                                  
                                   <asp:BoundField DataField="Model_ID" HeaderText="Model_ID" InsertVisible="False" ReadOnly="True" SortExpression="Model_ID" Visible="false"/>

                            </Columns>
                        </asp:GridView>

                        

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
        <div class="row-fluid">


            <div class="widget red">
                <div class="widget-title">
                    <h4>Edit Model</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->

                    <div class="control-group">
                        <label class="control-label">Name</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Model Name" class="input-medium" id="txtModelName" />

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Vehicle Type</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Vehicle Type" class="chzn-select-deselect span6"  id="lstVehicleType" runat="server">
                                
                            </select>
                        </div>
                    </div>

                     <div class="control-group">
                        <label class="control-label">Manufacturer Name</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Manufacturer" class="chzn-select-deselect span6"  id="lstManufacturerName" runat="server">
                                
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
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveModel" onserverclick="btnSaveModel_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelModel">Cancel</button>
                    </div>

                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>

    </form>
</asp:Content>
