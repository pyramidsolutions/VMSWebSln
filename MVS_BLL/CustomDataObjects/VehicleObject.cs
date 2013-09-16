using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class VehicleObject
    {
        public VehicleObject()
        { 
        }

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


        private string location_name;

        public string Location_Name
        {
            get { return location_name; }
            set { location_name = value; }
        }

        private string Supplier_Name;

        public string Supplier_NameProp
        {
            get { return Supplier_Name; }
            set { Supplier_Name = value; }
        }

        //get transaction code in SP

        // get Improvement_ID in SP
        
    }
}
