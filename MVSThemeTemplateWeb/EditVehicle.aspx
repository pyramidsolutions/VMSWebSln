<%@ Page Title="Edit Vehicle" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="EditVehicle.aspx.cs" Inherits="MVSThemeTemplateWeb.EditVehicle" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form1" runat="server" class="form-horizontal">
        <div class="row-fluid">
           
                <!-- BEGIN EXAMPLE TABLE widget-->
                <div class="widget red"  >
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>Vehicle Table</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>

                        </span>
                    </div>
                   <%--  <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Success!</h4>
                        <p>
                            The Vehicle has been updated succesfully
                        </p>
                    </div>
                    <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
                        <button data-dismiss="alert" class="close" type="button">×</button>
                        <h4 class="alert-heading">Error!</h4>
                        <p>
                            Please check the Form. The Vehicle has not been updated
                        </p>
                    </div>
                   --%>
                    <div class="widget-body">
                        <div class="control-group">
                        <asp:ListView ID="listViewVehicleCatalogue" runat="server" GroupItemCount="3"  OnItemCreated="repeatVehicle_ItemCreated" OnLoad="repeatVehicle_Load" DataKeyNames="Stock_Code" OnItemCommand="listViewVehicleCatalogue_ItemCommand">



                            <ItemTemplate>
                                <div class="span4">
                                    <!-- BEGIN GRID SAMPLE PORTLET-->
                                    <div class="widget yellow">
                                        <div class="widget-title">
                                            <h4 runat="server" id="headingVehicleName"><i class="icon-reorder"></i><%#DataBinder.Eval(Container, "DataItem.VehicleName")%></h4>
                                            <span class="tools">
                                                <a class="icon-chevron-down" href="javascript:;"></a>
                                             
                                            </span>
                                        </div>
                                        <div class="widget-body">

                                            <img runat="server" id="imgVehiclePicture1" src="img/blog/blog-thumb-1.jpg" alt="" height="100" width="100" />
                                            <div class="control-group">
                                                <label class="control-label">Colour</label>
                                                <div class="controls">
                                                    <label class="control-label" id="lblColour" runat="server"><%#DataBinder.Eval(Container, "DataItem.Colour")%></label>

                                                </div>
                                            </div>
                                            <div class="control-group">     
                                                <label class="control-label">Wholesale Price</label>
                                                <div class="controls">
                                                    <label class="control-label" id="lblWholesalePrice" runat="server"><%#DataBinder.Eval(Container, "DataItem.Wholesale_Price")%></label>

                                                </div>
                                            </div>
                                            <div class="control-group">
                                                <label class="control-label">Retail Price</label>
                                                <div class="controls">
                                                    <label class="control-label" id="lblRetailPrice" runat="server"><%#DataBinder.Eval(Container, "DataItem.Retail_Price")%></label>

                                                </div>
                                            </div>
                                            <span>
                                                <button class="btn btn-edit" runat="server" id="btnUploadImgPicture2"   itemid='<%#DataBinder.Eval(Container, "DataItem.Stock_Code")%>' ><i class="icon-ok"></i></button>
                                                <asp:ImageButton runat="server" CssClass="btn btn-edit" OnClick="btnUploadImgPicture2_ServerClick" CommandArgument='<%#DataBinder.Eval(Container, "DataItem.Stock_Code")%>' />
                                                
                                            </span>
                                        </div>
                                    </div>
                                </div>

                            </ItemTemplate>
                            <LayoutTemplate>

                                <asp:PlaceHolder runat="server" ID="groupPlaceholder"></asp:PlaceHolder>

                            </LayoutTemplate>

                            <GroupTemplate>
                                <tr runat="server" id="ProductsRow">
                                    <td runat="server" id="itemPlaceholder" />
                                </tr>
                            </GroupTemplate>
                        </asp:ListView>


                        <asp:SqlDataSource ID="spVehicleCatalogueDS" runat="server" ConnectionString="<%$ ConnectionStrings:MVSSqlDev2008ConnectionString %>" SelectCommand="sp_GetVehicleCatalogue" SelectCommandType="StoredProcedure"></asp:SqlDataSource>

                            </div>
                    </div>
                </div>
                <!-- END EXAMPLE TABLE widget-->
            
        </div>
        

    </form>
</asp:Content>
