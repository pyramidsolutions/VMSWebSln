<%@ Page Title="Add Company" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddCompany.aspx.cs" Inherits="MVSThemeTemplateWeb.AddCompany" EnableEventValidation="true" %>

<asp:Content runat="server" ContentPlaceHolderID="PageContent">
    <div class="row-fluid">
        <div class="span12">
            <!-- BEGIN SAMPLE FORMPORTLET-->
            <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Company has been added succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The company has not been added
                </p>
            </div>
            <div class="widget green">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>Add Company</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->
                    <form runat="server" class="form-horizontal">
                        <div class="control-group">
                            <label class="control-label">Company Name</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Company Name" class="input-medium" id="txtCompanyName" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtCompanyAddress" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address Line 2</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address Line 2" class="input-large" id="txtCompanyAddressLine2" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">City</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="City" class="input-medium" id="txtCompanyCity" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Code</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Code" class="input-small" id="txtCompanyCode" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtCompanyTelephone" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone 2</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231235" id="txtCompanyTelephone2" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Fax</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231236" id="txtCompanyFax" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Email</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="email" placeholder="example@mail.com" id="txtCompanyEmail" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Website</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="text" placeholder="www.company.com" id="txtCompanyWebsite" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">VAT Number</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="text" placeholder="WXYX1234" id="txtCompanyVATNumbwer" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">VAT Percentage</label>
                            <div class="controls">
                                <input class="input-mini" runat="server" type="number" id="txtCompanyVATPercentage" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">Company Logo</label>
                            <div class="controls">
                                <input class="input-xxlarge" runat="server" type="file" id="fileUplaodCompanyLogo" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxCompanyDisable" />
                            </div>
                        </div>

                        <div class="form-actions">
                            <button type="submit" runat="server" class="btn btn-success" id="btnSaveCompany" onserverclick="btnSaveCompany_ServerClick" >Save</button>
                            <button type="button" runat="server" class="btn" id="btnCancelCompany">Cancel</button>
                        </div>
                    </form>
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    </div>


</asp:Content>
