using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using UtilityLibrary;

namespace MVSThemeTemplateWeb
{
    public partial class EditVehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void repeatVehicle_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            if (e.Item is ListViewDataItem)
            {
                ImageUtility imageObj = new ImageUtility();
                DataTable items = (DataTable)ViewState["VehicleItems"];
                var item = e.Item;
                HtmlImage image = (HtmlImage)item.FindControl("imgVehiclePicture1");
                int index = e.Item.DataItemIndex;

                DataRow dr = items.Rows[index];
                byte[] picture1 = DBUtility.readDBImage(dr,"Picture_1");
                if (image != null && picture1 != null)
                {
                    image.Src = imageObj.byteArrayToBase64String(picture1);
                }
            }
        }

        protected void btnUploadImgPicture2_ServerClick(object sender, EventArgs e)
        {
            var button = (ImageButton)sender as ImageButton;
            int id = int.Parse(button.CommandArgument);
            //ManageVehicle manageVehicle = new ManageVehicle();
            //DataTable editVehcmanageVehicle.getAVehicle(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString, id)
            Response.Redirect("~/EditSelectedVehicle.aspx?id="+ id, true);
        }

        protected void btnRemoveImgPicture2_ServerClick(object sender, EventArgs e)
        {

        }

        protected void repeatVehicle_Load(object sender, EventArgs e)
        {
            if (ViewState["VehicleItems"] == null)
            {
                ManageVehicle vehicleObj = new ManageVehicle();
                var vehicleCatalogue = vehicleObj.getVehicleCatalogue(ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);
                ViewState.Add("VehicleItems", vehicleCatalogue);
                listViewVehicleCatalogue.DataSource = vehicleCatalogue;
                listViewVehicleCatalogue.DataBind();
               
            }
            else
            {
                listViewVehicleCatalogue.DataSource = ViewState["VehicleItems"];
                listViewVehicleCatalogue.DataBind();
            }
        }

        protected void listViewVehicleCatalogue_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
           
        }
    }
}