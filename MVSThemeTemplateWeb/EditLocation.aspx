<%@ Page Title="Edit Location" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditLocation.aspx.cs" Inherits="MVSThemeTemplateWeb.EditLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
      <form id="form2" runat="server" class="form-horizontal">
     <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget grey" id="divCompanyData" runat="server" >
                    <div class="widget-title">
                        <h4>Location Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                           
                        </span>
                    </div>
                      <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false" >
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Success!</h4>
                <p>
                   The Location has been updated succesfully
                </p>
            </div>
            <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                <button data-dismiss="alert" class="close" type="button">×</button>
                <h4 class="alert-heading">Error!</h4>
                <p>
                    Please check the Form. The Location has not been updated
                </p>
            </div>
                    <div class="widget-body">
                        <asp:GridView CssClass="table table-striped table-bordered" ID="grdLocation" runat="server" AutoGenerateColumns="False" OnLoad="grdLocation_Load" OnRowCommand="grdLocation_RowCommand" DataKeyNames="Location_ID"  >
                            <Columns>
                                      <asp:TemplateField >
                                    <ItemTemplate >
                                        <asp:Button CssClass="btn-edit" ID = "button2" runat="server" CommandArgument='<%# Bind("Location_ID") %>' CommandName="EditRow" Text="Edit" UseSubmitBehavior="False" CausesValidation="False">

                                        </asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:BoundField DataField="Location_Name" HeaderText="Name" SortExpression="Location_Name" >
                                    
                                </asp:BoundField>
                                 <asp:BoundField DataField="Location_Description" HeaderText="Description" SortExpression="Location_Description" >
                                    
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" >
                                    
                                </asp:CheckBoxField>

                                
                                <asp:BoundField DataField="Location_ID" HeaderText="Location_ID" SortExpression="Location_ID" InsertVisible="False" ReadOnly="True" Visible="false"  >
                                    
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>



                    



                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            </div>
        </div>
      <div class="row-fluid">
        
            
            <div class="widget grey">
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
                                <input type="text" runat="server" placeholder="Location Name" class="input-medium" id="txtLocationName" />

                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">Description</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="Description" class="input-large" id="txtLocationDescription" />

                            </div>
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Disable</label>
                            <div class="controls">
                                <input class="checkbox" runat="server" type="checkbox" id="chkBoxLocationDisable" />
                            </div>
                        </div>

                        <div class="form-actions">
                            <button type="button" runat="server" class="btn btn-success" id="btnSaveLocation" onserverclick="btnSaveLocation_ServerClick" >Save</button>
                            <button type="button" runat="server" class="btn" id="btnCancelCompany">Cancel</button>
                        </div>
                    
                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    
    </form>
</asp:Content>
