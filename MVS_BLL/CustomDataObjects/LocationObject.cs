using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class LocationObject
    {
        public LocationObject()
        { }

        private string location_description;

        public string Location_Description
        {
            get { return location_description; }
            set { location_description = value; }
        }

        private bool disable;

        public bool Disable
        {
            get { return disable; }
            set { disable = value; }
        }

        private string location_name;

        public string Location_Name
        {
            get { return location_name; }
            set { location_name = value; }
        }
    }
}
