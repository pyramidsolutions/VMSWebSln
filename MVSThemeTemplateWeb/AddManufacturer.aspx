<%@ Page Title="Add Manufacturer" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddManufacturer.aspx.cs" Inherits="MVSThemeTemplateWeb.AddManufacturer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
      <div class="row-fluid">
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Manufacturer has been Added succesfully
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Manufacturer has not been added
            </p>
        </div>

        <div class="widget purple">
            <div class="widget-title">
                <h4>Add Manufacturer</h4>
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
                            <input type="text" runat="server" placeholder="Manufacturer Name" class="input-medium" id="txtManufacturerName" />

                        </div>
                    </div>
                    
                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveManufacturer" onserverclick="btnSaveManufacturer_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelManufacturer">Cancel</button>
                    </div>
                </form>
                <!-- END FORM-->
            </div>
        </div>
        <!-- END SAMPLE FORM PORTLET-->
    </div>
</asp:Content>
