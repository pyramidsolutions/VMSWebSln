using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVS_Enum;

namespace MVS_BLL.CustomDataObjects
{
    public class AddressObject
    {
        public string Address_Line_1 { get; set; }

        public string Address_Line_2 { get; set; }

        public string City { get; set; }

        public string Postal_Code { get; set; }

        public MVS_Enum.CommonEnums.AddressType AddressType { get; set; }
    }
}
