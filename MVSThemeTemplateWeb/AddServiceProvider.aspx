<%@ Page Title="Add Service Provider" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddServiceProvider.aspx.cs" Inherits="MVSThemeTemplateWeb.AddServiceProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
      <div class="row-fluid">
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Service Provider has been Added succesfully
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Service Provider has not been added
            </p>
        </div>

        <div class="widget yellow">
            <div class="widget-title">
                <h4>Add Service Provider</h4>
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
                            <input type="text" runat="server" placeholder="Service Provider Name" class="input-medium" id="txtServiceProviderName" />

                        </div>
                    </div>
                    <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtServiceProviderAddress" />

                            </div>
                        </div>
                     <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtServiceProviderTelephone" />
                            </div>
                        </div>
                    <div class="control-group">
                        <label class="control-label">Category</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Category" class="chzn-select-deselect span6"  id="lstCategory" runat="server">
                                
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
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveServiceProvider" onserverclick="btnSaveServiceProvider_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelServiceProvider">Cancel</button>
                    </div>
                </form>
                <!-- END FORM-->
            </div>
        </div>
        <!-- END SAMPLE FORM PORTLET-->
    </div>
</asp:Content>
