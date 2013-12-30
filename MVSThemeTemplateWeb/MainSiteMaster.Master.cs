using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVSThemeTemplateWeb
{
    public partial class MainSiteMaster : System.Web.UI.MasterPage
    {

        private string _strHeaderText;
        public string HeaderText
        {
            get
            {
                return Page.Header.Title;
            }
            set
            {
                _strHeaderText = value;
            }
        }

        private string _breadCrumb;
        public string BreadCrumb
        {
            get
            {
                return Page.Header.Title;
            }
            set
            {
                _breadCrumb = value;
            }
        }

        private string _parent;
        public string Parent
        {
            get
            {
                string newString = Page.Header.Title.Substring(Page.Header.Title.IndexOf(' ') + 1);
                return newString;
            }
            set
            {
                _parent = value;
            }
        }

        private string _current;
        public string Current
        {
            get
            {
                return Page.Header.Title;
            }
            set
            {
                _current = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageTitle.InnerText = this.HeaderText;

                lnkParent.InnerText = this.Parent;
                lnkParent.Disabled = true;

                lnkCurrentPage.InnerText = this.Current;
                lnkParent.Disabled = true;

            }
        }
    }
}