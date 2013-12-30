<%@ Page Title="Add Improvement" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddImprovement.aspx.cs" Inherits="MVSThemeTemplateWeb.AddImprovement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <div class="row-fluid">
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Improvement has been Added succesfully
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Improvement has not been added
            </p>
        </div>

        <div class="widget green">
            <div class="widget-title">
                <h4>Add Improvement</h4>
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
                            <input type="text" runat="server" placeholder="Improvement Name" class="input-medium" id="txtImprovementName" />

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Description</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Description" class="input-xxlarge" id="txtImprovementDescription" />

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Price</label>
                        <div class="controls">
                            <div class="input-prepend input-append">
                                <span class="add-on">R</span><input runat="server" id="txtImprovementPrice" class=" " type="text" /><span class="add-on">.00</span>
                            </div>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Service Provider</label>
                        <div class="controls">
                            <select data-placeholder="Choose a service provider" class="chzn-select-deselect span6" tabindex="-1" id="lstServiceProvider" runat="server">
                              
                            </select>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Vehicle</label>
                         <div class="controls">
                            <select data-placeholder="Choose a service provider" class="chzn-select-deselect span6" tabindex="-1" id="lstVehicle" runat="server">
                             
                            </select>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Disable</label>
                        <div class="controls">
                            <input class="checkbox" runat="server" type="checkbox" id="chkBoxImprovementDisable" />
                        </div>
                    </div>

                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveImprovement" onserverclick="btnSaveCustomer_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelImprovement">Cancel</button>
                    </div>
                </form>
                <!-- END FORM-->
            </div>
        </div>
        <!-- END SAMPLE FORM PORTLET-->
    </div>
</asp:Content>
