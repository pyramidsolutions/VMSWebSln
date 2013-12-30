<%@ Page Title="Edit Manufacturer" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditManufacturer.aspx.cs" Inherits="MVSThemeTemplateWeb.EditManufacturer" %>

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
                    <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Success!</h4>
                        <p>
                            The Manufacturer has been updated succesfully
                        </p>
                    </div>
                    <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Error!</h4>
                        <p>
                            Please check the Form. The Manufacturer has not been updated
                        </p>
                    </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdManufacturer" runat="server" AutoGenerateColumns="False" OnLoad="grdManufacturer_Load" OnRowCommand="grdManufacturer_RowCommand" DataKeyNames="Manufacturer_ID">
                            <Columns>
                                   <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-edit" ID = "button2" runat="server" CommandArgument='<%# Bind("Manufacturer_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Manufacturer_Name" HeaderText="Name" SortExpression="Manufacturer_Name"></asp:BoundField>
                                <asp:BoundField DataField="Manufacturer_ID" HeaderText="Manufacturer_ID" SortExpression="Manufacturer_ID" InsertVisible="False" ReadOnly="True" Visible="false"></asp:BoundField>

                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
        <div class="row-fluid">


            <div class="widget purple">
                <div class="widget-title">
                    <h4>Edit Location</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->

                    <div class="control-group">
                        <label class="control-label">Name</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Manufacturer Name" class="input-medium" id="txtManufacturerName" />

                        </div>
                    </div>
                   
                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveManufacturer" onserverclick="btnSaveManufacturer_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelManufacturer">Cancel</button>
                    </div>

                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>

    </form>
</asp:Content>
