﻿using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilityLibrary;
namespace MVSThemeTemplateWeb
{
    public partial class AddVehicle : System.Web.UI.Page
    {
        ImageUtility imageUtil;
        private Process proc;

        protected void Page_Load(object sender, EventArgs e)
        {
            bindLstManufacturer();
            bindLstModel();
            bindLstSupplier();
            bindLstLocation();
        }

        

        protected void btnSaveCustomer_ServerClick(object sender, EventArgs e)
        {
          
        }

        private void bindLstManufacturer()
        {
            ManageManufacturer manageManufacturer = new ManageManufacturer();

            var lstManufacturer = manageManufacturer.getManufacturerList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicleManufacturerName.DataSource = lstManufacturer;
            lstVehicleManufacturerName.DataTextField = "Manufacturer_Name";
            lstVehicleManufacturerName.DataValueField = "Manufacturer_Name";
            lstVehicleManufacturerName.DataBind();
        }

        private void bindLstModel()
        {
            ManageModel manageModel = new ManageModel();

            var lstModel = manageModel.getModelList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicleModelName.DataSource = lstModel;
            lstVehicleModelName.DataTextField = "Model_Name";
            lstVehicleModelName.DataValueField = "Model_Name";
            lstVehicleModelName.DataBind();
        }

        private void bindLstSupplier()
        {
            ManageSupplier manageSupplier = new ManageSupplier();

            var lstSupplier = manageSupplier.getSupplierList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicleSupplier.DataSource = lstSupplier;
            lstVehicleSupplier.DataTextField = "Supplier_name";
            lstVehicleSupplier.DataValueField = "Supplier_name";
            lstVehicleSupplier.DataBind();
        }

        private void bindLstLocation()
        {
            ManageLocation manageLocation = new ManageLocation();

            var lstLocation = manageLocation.getLocationList(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
            lstVehicleLocation.DataSource = lstLocation;
            lstVehicleLocation.DataTextField = "Location_Name";
            lstVehicleLocation.DataValueField = "Location_Name";
            lstVehicleLocation.DataBind();
        }

        protected void filePicture1_Click(object sender, EventArgs e)
        {
 
        }

        protected void btnSaveVehicle_ServerClick(object sender, EventArgs e)
        {
            VehicleObject obj = new VehicleObject();
            imageUtil = new ImageUtility();

            obj.AC = chkBoxAC.Checked;
            obj.Airbag = chkBoxAirbags.Checked;
            obj.AL = chkBoxAL.Checked;
            if (dateVehicleArrivalDate.Value != "")
            {
                obj.Arrival_Date = DateTime.ParseExact(dateVehicleArrivalDate.Value, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            obj.Automatic_Transmission = chkBoxAL.Checked;
            obj.CD = chkBoxAL.Checked;
            obj.Chassis_Number = txtVehicleChassisNumber.Value;
            obj.CI = chkBoxCI.Checked;
            obj.Colour = txtVehicleColour.Value;
            obj.Condition = txtVehicleCondition.Value;
            obj.COR = chkBoxCOR.Checked;
            if (txtVehicleCostPrice.Value != "")
            {
                obj.Cost_Price = Convert.ToDecimal(txtVehicleCostPrice.Value);
            }
            obj.Engine_Number = txtVehicleEngineNumber.Value;
            obj.Extra_Features = txtVehicleExtraFeatures.Value;
            obj.FSH = chkBoxFSH.Checked;
            obj.Gearlock = chkBoxGearlock.Checked;
            obj.Leather = chkBoxLeather.Checked;
            obj.Location_Name = lstVehicleLocation.Value;
            obj.Mags = chkBoxMags.Checked;
            obj.Manufacturer_Name = lstVehicleManufacturerName.Value;
            if (txtVehicleMileage.Value != "")
            {
                obj.Mileage = Convert.ToInt32(txtVehicleMileage.Value);
            }
            obj.Model_Name = lstVehicleModelName.Value;
            obj.MP3 = chkBoxMP3.Checked;
            if (Session["Image1"] != null)
            {
                obj.Picture_1 = imageUtil.imageToByteArray(Session["Image1"].ToString());
                
            }
            if (Session["Image2"] != null)
            {
                obj.Picture_2 = imageUtil.imageToByteArray(Session["Image2"].ToString());
            }
            if (Session["Image3"] != null)
            {
                obj.Picture_3 = imageUtil.imageToByteArray(Session["Image3"].ToString());
            }
            obj.PS = chkBoxPS.Checked;
            obj.Registration_Number = txtVehicleRegistrationNumber.Value;
            if (txtVehicleRetailPrice.Value != "")
            {
                obj.Retail_Price = Convert.ToDecimal(txtVehicleRetailPrice.Value);
            }
            obj.RT = chkBoxRT.Checked;
            obj.Sports_Kit = chkBoxSportsKit.Checked;
            obj.SR = chkBoxSR.Checked;
            obj.Supplier_NameProp = lstVehicleSupplier.Value;
            obj.Vehicle_Status = lstVehicleStatus.Value;
            if (txtVehicleWholesalePrice.Value != "")
            {
                obj.Wholesale_Price = Convert.ToDecimal(txtVehicleWholesalePrice.Value);
            }

            ManageVehicle vehicleObj = new ManageVehicle();

            bool success = vehicleObj.insert(obj, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (success)
            {
                divSuccess.Visible = true;
            }
            else
                divFailure.Visible = true;
            imageUtil = null;
        }

        protected void btnUploadImgPicture1_ServerClick(object sender, EventArgs e)
        {
            if (filePicture1.HasFiles)
            {
                int count = 0;
                foreach (HttpPostedFile file in filePicture1.PostedFiles)
                {
                    count++;
                    imageUtil = new ImageUtility();
                    string realPhysicalPath = Path.Combine(Server.MapPath("~/upload/"), file.FileName);
                    file.SaveAs(realPhysicalPath);
                    //imgVehiclePicture1.Src = realPhysicalPath;

                    //imgVehiclePicture.Attributes["src"] = imageUtil.getBase64String(realPhysicalPath);
                    Session.Add("Image"+count, realPhysicalPath);
                    imageUtil.Dispose();

                    filePicture1 = null;
                    GC.Collect();
                    
                }

                imgVehiclePicture1.Attributes["src"] = imageUtil.getBase64String(Session["Image1"].ToString());
                if (Session["Image2"] != null)
                {
                    imgVehiclePicture2.Attributes["src"] = imageUtil.getBase64String(Session["Image2"].ToString());
                }
                if (Session["Image3"] != null)
                {
                    imgVehiclePicture3.Attributes["src"] = imageUtil.getBase64String(Session["Image3"].ToString());
                }
            }
               
        }
        
        protected void btnUploadImgPicture2_ServerClick(object sender, EventArgs e)
        {
            
            //    if (filePicture2.PostedFile.FileName != "")
            //    {
            //        imageUtil = new ImageUtility();
            //        string realPhysicalPath = Path.Combine(Server.MapPath("~/upload/"), filePicture2.PostedFile.FileName);
            //        filePicture1.PostedFile.SaveAs(realPhysicalPath);
            //        //imgVehiclePicture2.Src = realPhysicalPath;
                   
            //            imgVehiclePicture2.Attributes["src"] = imageUtil.getBase64String(realPhysicalPath);
            //            Session.Add("Image2", realPhysicalPath);
            //            imageUtil = null;
                    

                
            //}
        }

      

        protected void btnUploadImgPicture3_ServerClick(object sender, EventArgs e)
        {
            
                //if (filePicture3.PostedFile.FileName != "")
                //{
                //    imageUtil = new ImageUtility();
                //    string realPhysicalPath = Path.Combine(Server.MapPath("~/upload/"), filePicture3.PostedFile.FileName);
                //    filePicture3.PostedFile.SaveAs(realPhysicalPath);
                //    //imgVehiclePicture3.Src = realPhysicalPath;
                    
                //        imgVehiclePicture3.Attributes["src"] = imageUtil.getBase64String(realPhysicalPath);
                //        Session.Add("Image3", realPhysicalPath);
                //        imageUtil = null;
                    
                //}
            
        }

        protected void btnRemoveImgPicture1_ServerClick(object sender, EventArgs e)
        {
           
                if (Session["Image1"] != null)
                {
                    imageUtil = new ImageUtility();
                    string realPhysicalPath = Server.MapPath("~/img/blog/blog-thumb-1.jpg");
                    
                        imgVehiclePicture1.Src = imageUtil.getBase64String(realPhysicalPath);
                        Session.Remove("Image1");
                        imageUtil = null;
                    
                }
            
        }

        protected void btnRemoveImgPicture2_ServerClick(object sender, EventArgs e)
        {
                if (Session["Image2"] != null)
                {
                    imageUtil = new ImageUtility();
                    string realPhysicalPath = Server.MapPath("~/img/blog/blog-thumb-1.jpg");
                    
                        imgVehiclePicture2.Src = imageUtil.getBase64String(realPhysicalPath);
                        Session.Remove("Image2");
                        imageUtil = null;
                    
                }
            
        }

        protected void btnRemoveImgPicture3_ServerClick(object sender, EventArgs e)
        {
            
                if (Session["Image3"] != null)
                {
                    imageUtil = new ImageUtility();
                    string realPhysicalPath = Server.MapPath("~/img/blog/blog-thumb-1.jpg");
                    
                        imgVehiclePicture3.Src = imageUtil.getBase64String(realPhysicalPath);
                        Session.Remove("Image3");
                        imageUtil = null;
                }
                
            
        }

        

    }
}