using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class ManufacturerObject
    {
        public ManufacturerObject()
        { }

        private string manufacturer_name;

        public string Manufacturer_Name
        {
            get { return manufacturer_name; }
            set { manufacturer_name = value; }
        }
    }
}
