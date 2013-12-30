<%@ Page Title="Add Location" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddLocation.aspx.cs" Inherits="MVSThemeTemplateWeb.AddLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <div class="row-fluid">
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Location has been Added succesfully
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Location has not been added
            </p>
        </div>

        <div class="widget grey">
            <div class="widget-title">
                <h4>Add Location</h4>
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
                            <input type="text" runat="server" placeholder="Location Name" class="input-medium" id="txtLocationName" />

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Description</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Description" class="input-xxlarge" id="txtLocationDescription" />

                        </div>
                    </div>
                    
                    <div class="control-group">
                        <label class="control-label">Disable</label>
                        <div class="controls">
                            <input class="checkbox" runat="server" type="checkbox" id="chkBoxLocationDisable" />
                        </div>
                    </div>

                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveLocation" onserverclick="btnSaveLocation_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelLocation">Cancel</button>
                    </div>
                </form>
                <!-- END FORM-->
            </div>
        </div>
        <!-- END SAMPLE FORM PORTLET-->
    </div>
</asp:Content>
