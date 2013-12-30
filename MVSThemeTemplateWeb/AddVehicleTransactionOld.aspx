<%@ Page Title="Add Vehicle Transaction" Language="C#" MasterPageFile="~/MainSiteMaster.Master" AutoEventWireup="true" CodeBehind="AddVehicleTransactionOld.aspx.cs" Inherits="MVSThemeTemplateWeb.AddVehicleTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <script type="text/javascript" >

        function getVehicles()
        {
            PageMethods.GetCurrentDate(success, fail);
            return false;
        }

        function call() {
            PageMethods.GetCurrentDate(success, fail);
            return false;
        }


        function success(msg) {
            alert("Success " + msg);
        }

        function fail(xhr, status) {
            alert("Fail " + xhr.responseText + " " + status);
        }


    </script>
    <form id="Form2" runat="server" class="form-horizontal">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
        <div class="alert alert-block alert-success fade in" runat="server" id="divSuccess" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Success!</h4>
            <p>
                The Transaction has been Added succesfully 
            </p>
        </div>
        <div class="alert alert-block alert-error fade in" runat="server" id="divFailure" visible="false">
            <button data-dismiss="alert" class="close" type="button">×</button>
            <h4 class="alert-heading">Error!</h4>
            <p>
                Please check the Form. The Transaction has not been added
            </p>
        </div>
        <div class="row-fluid">


            <div class="widget blue">
                <div class="widget-title">
                    <h4>Transaction Details</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->

                    <div class="control-group">
                        <label class="control-label">Manufacturer</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Manufacturer" class="chzn-select-deselect span6" id="lstVehicleManufacturerName" runat="server">
                            </select>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Model</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Model" class="chzn-select-deselect span6" id="lstVehicleModelName" runat="server">
                            </select>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Location</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Location" class="chzn-select-deselect span6" id="lstVehicleLocation" runat="server">
                            </select>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Colour</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Vehicle Colour" class="input-large" id="txtVehicleColour" />

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Chassis Number</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Chassis Number" class="input-large" id="txtVehicleChassisNumber" />
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Engine Number</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Engine Number" class="input-large" id="txtVehicleEngineNumber" />
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Registration Number</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="ND12345" class="input-medium" id="txtVehicleRegistrationNumber" />
                        </div>
                    </div>

                    <div class="control-group">
                        <label class="control-label">Mileage</label>
                        <div class="controls">
                            <input type="number" runat="server" class="input-small" id="txtVehicleMileage" />
                        </div>
                    </div>

                    <div class="control-group">
                        <label class="control-label">Supplier</label>
                        <div class="controls">
                            <select data-placeholder="Choose a Supplier" class="chzn-select-deselect span6" id="lstVehicleSupplier" runat="server">
                            </select>
                        </div>
                    </div>

                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>

        <div class="row-fluid">


            <div class="widget orange">
                <div class="widget-title">
                    <h4>Vehicles</h4>
                    <span class="tools">
                        
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <div class="control-group">
                        <label class="control-label">Search</label>
                        <div class="controls">
                            <input type="text" class="input-xxlarge" runat="server" id="txtBoxProductSearch"/>
                          
                        </div>
                        <button type="submit" class="btn ">SEARCH</button>
                    </div>
                    <div class="control-group">

                        <asp:Repeater ID="rptVehicles" runat="server">
                            <HeaderTemplate>
                                <table class="table table-striped table-bordered table-advance table-hover">
                                    <thead>
                                        <tr>
                                            <th><i class="icon-bullhorn"></i>Company</th>
                                            <th class="hidden-phone"><i class="icon-question-sign"></i>Descrition</th>
                                            <th><i class="icon-bookmark"></i>Profit</th>
                                            <th><i class=" icon-edit"></i>Status</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                    <tr>
                                        <td><a href="#">Vector Ltd</a></td>
                                        <td class="hidden-phone">Lorem Ipsum dorolo imit</td>
                                        <td>12120.00$ </td>
                                        <td><span class="label label-important label-mini">Due</span></td>
                                        <td>
                                            <button class="btn btn-success"><i class="icon-ok"></i></button>
                                            <button class="btn btn-primary"><i class="icon-pencil"></i></button>
                                            <button class="btn btn-danger"><i class="icon-trash "></i></button>
                                        </td>
                                    </tr>

                                </tbody>
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>

        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN SAMPLE FORMPORTLET-->
                <div class="widget red">
                    <div class="widget-title">
                        <h4>
                            <i class="icon-reorder"></i>Vehicle Features
                        </h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>

                        </span>
                    </div>
                    <div class="widget-body">
                        <!-- BEGIN FORM-->

                        <div class="control-group">

                            <div class="span3 ">

                                <label class="control-label">Automatic Transmission</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxVehicleAutomaticTransmission" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">COR</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxCOR" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">AC</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxAC" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">CI</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxCI" />
                                </div>

                            </div>
                        </div>
                        <div class="control-group">
                            <div class="span3 ">

                                <label class="control-label">PS</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxPS" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">AL</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxAL" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">Leather</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxLeather" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">RT</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxRT" />
                                </div>

                            </div>
                        </div>
                        <div class="control-group">
                            <div class="span3 ">

                                <label class="control-label">CD</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxCD" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">MP3</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxMP3" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">FSH</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxFSH" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">SR</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxSR" />
                                </div>

                            </div>
                        </div>

                        <div class="control-group">
                            <div class="span3 ">

                                <label class="control-label">Sports Kit</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxSportsKit" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">Airbags</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxAirbags" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">Mags</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxMags" />
                                </div>

                            </div>
                            <div class="span3 ">

                                <label class="control-label">Gearlock</label>
                                <div class="controls">
                                    <input class="checkbox" runat="server" type="checkbox" id="chkBoxGearlock" />
                                </div>

                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">Extra Features</label>
                            <div class="controls">
                                <input type="text" runat="server" placeholder="" class="input-xxlarge" id="txtVehicleExtraFeatures" />
                            </div>
                        </div>

                        <!-- END FORM-->
                    </div>
                </div>
                <!-- END SAMPLE FORM PORTLET-->
            </div>
        </div>

        <div class="row-fluid">


            <div class="widget blue">
                <div class="widget-title">
                    <h4>Vehicle Cost</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>

                    </span>
                </div>
                <div class="widget-body">
                    <!-- BEGIN FORM-->


                    <div class="control-group">
                        <label class="control-label">Cost Price</label>
                        <div class="controls">
                            <div class="input-prepend input-append">
                                <span class="add-on">R</span><input runat="server" id="txtVehicleCostPrice" class=" " type="text" /><span class="add-on">.00</span>
                            </div>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Retail Price</label>
                        <div class="controls">
                            <div class="input-prepend input-append">
                                <span class="add-on">R</span><input runat="server" id="txtVehicleRetailPrice" class=" " type="text" /><span class="add-on">.00</span>
                            </div>
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Wholesale Price</label>
                        <div class="controls">
                            <div class="input-prepend input-append">
                                <span class="add-on">R</span><input runat="server" id="txtVehicleWholesalePrice" class=" " type="text" /><span class="add-on">.00</span>
                            </div>
                        </div>
                    </div>

                    <div class="control-group">
                        <label class="control-label">Condition</label>
                        <div class="controls">
                            <input type="text" runat="server" placeholder="Condition" class="input-xxlarge" id="txtVehicleCondition" />
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Arrival Date</label>
                        <div class="controls">
                            <input id="dateVehicleArrivalDate" type="date" size="16" class="m-ctrl-medium" runat="server" />
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label">Vehicle Status</label>
                        <div class="controls">
                            <select data-placeholder="Choose a status" class="chzn-select-deselect span6" id="lstVehicleStatus" runat="server">
                                <option value="OnFloor">On Showroom Floor</option>
                                <option value="InRepair">At Service Provider for Repair</option>

                            </select>
                        </div>
                    </div>
                    <div class="form-actions">
                        <button type="button" runat="server" class="btn btn-success" id="btnSaveVehicle" onserverclick="btnSaveVehicle_ServerClick">Save</button>
                        <button type="button" runat="server" class="btn" id="btnCancelTransaction">Cancel</button>
                    </div>

                    <!-- END FORM-->
                </div>
            </div>
            <!-- END SAMPLE FORM PORTLET-->
        </div>
    </form>
</asp:Content>
