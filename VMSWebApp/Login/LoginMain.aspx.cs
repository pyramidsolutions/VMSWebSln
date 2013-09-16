using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVS_BLL.CustomDataObjects;
using MVS_BLL.ManagementClasses;
using System.Configuration;
using System.Data;

namespace VMSWebApp.Login
{
    public partial class LoginMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserObject userLogin = new UserObject();

            userLogin.Account_Name = username.Value;
            userLogin.Account_Password = password.Value;

            ManageUsers manageUsers = new ManageUsers();

            UserObject userCheckObject = manageUsers.login(userLogin, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (userCheckObject != null)
            {
                Response.Redirect("~/Default.aspx");
                Session.Add("CurrentUser", userCheckObject);
            }
            else
            {
                Response.Write("Invalid User");
            }


        }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            UserObject userLogin = new UserObject();

            userLogin.Account_Name = username.Value;
            userLogin.Account_Password = password.Value;

            ManageUsers manageUsers = new ManageUsers();

            UserObject userCheckObject = manageUsers.login(userLogin, ConfigurationManager.ConnectionStrings["MVSSqlDev2008ConnectionString"].ConnectionString);

            if (userCheckObject != null && userCheckObject.Account_Name != null)
            {
               Session.Add("CurrentUser", userCheckObject);
               Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write("Invalid User");
            }

        }

        
    }
}