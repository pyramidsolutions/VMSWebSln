<%@ Page Title="Add Supplier" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddSupplier.aspx.cs" Inherits="MVSThemeTemplateWeb.AddSupplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
      <div class="row-fluid">
                <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Supplier has been Added succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The supplier has not been added
                </p>
            </div>
            
            <div class="widget green">
                <div class="widget-title">
                    <h4>Add Supplier</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->
                    <form id="Form1" runat="server" class="form-horizontal">
                        <div class="control-group">
                            <label class="control-label">Supplier Name</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Supplier Name" class="input-medium" id="txtSupplierName" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address" class="input-large" id="txtSupplierAddress" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Address Line 2</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Address Line 2" class="input-large" id="txtSupplierAddressLine2" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">City</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="City" class="input-medium" id="txtSupplierCity" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Code</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Code" class="input-small" id="txtSupplierCode" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone</label>
                            <div class="controls">
                                <input type="tel" runat="server" placeholder="0111231234" class="input-medium" id="txtSupplierTelephone" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Telephone 2</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231235" id="txtSupplierTelephone2" />

                            </div>
                        </div>
                         <div class="control-group">
                            <label class="control-label">Cellphone</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0821231235" id="txtSupplierCellphone" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Fax</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="tel" placeholder="0111231236" id="txtSupplierFax" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Email</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="email" placeholder="example@mail.com" id="txtSupplierEmail" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Wholesale Supplier</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkSupplierWholesale" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">VAT Number</label>
                            <div class="controls">
                                <input class="input-medium" runat="server" type="text" placeholder="WXYX1234" id="txtSupplierVATNumber" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">Representative</label>
                            <div class="controls">
                                <input class="input-large" runat="server" type="number" id="txtSupplierRepresentative" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">CK Number</label>
                            <div class="controls">
                                <input class="input-large" runat="server" type="text"  id="txtSupplierCKNumber" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxSupplierDisable" />
                            </div>
                        </div>

                        <div class="form-actions">
                            <button type="button" runat="server" class="btn btn-success" id="btnSaveSupplier" onserverclick="btnSaveSupplier_ServerClick"  >Save</button>
                            <button type="button" runat="server" class="btn" id="btnCancelSupplier">Cancel</button>
                        </div>
                    </form>
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
</asp:Content>
