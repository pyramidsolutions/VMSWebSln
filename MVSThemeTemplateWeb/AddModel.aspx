<%@ Page Title="Add Model" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddModel.aspx.cs" Inherits="MVSThemeTemplateWeb.AddModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <div class="row-fluid">
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Model has been Added succesfully
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Model has not been added
            </p>
        </div>

        <div class="widget red">
            <div class="widget-title">
                <h4>Add Model</h4>
                <span class="tools">
                    <a href="javascript:;" class="icon-chevron-down"></a>

                </span>
            </div>
            <div class="widget-body">
                <!-- BEGIN FORM-->
                <form id="Form1" runat="server" class="form-horizontal">
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
                </form>
                <!-- END FORM-->
            </div>
        </div>
        <!-- END SAMPLE FORM PORTLET-->
    </div>
</asp:Content>
