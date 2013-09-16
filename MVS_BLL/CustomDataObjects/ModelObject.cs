using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class ModelObject
    {
        public ModelObject()
        { }

        private string manufacturer_name;

        public string Manufacturer_Name
        {
            get { return manufacturer_name; }
            set { manufacturer_name = value; }
        }

        private string model_name;

        public string Model_Name
        {
            get { return model_name; }
            set { model_name = value; }
        }

        private string vehicle_type;

        public string Vehicle_Type
        {
            get { return vehicle_type; }
            set { vehicle_type = value; }
        }

        private bool disable;

        public bool Disable
        {
            get { return disable; }
            set { disable = value; }
        }

    }
}
