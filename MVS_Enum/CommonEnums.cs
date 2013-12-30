using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_Enum
{
    public class CommonEnums
    {
        public enum AddressType 
        {
            BillingAddress = "Billing Address",
            ShippingAddress = "Shipping Address",
            PostalAddress = "Postal Address",
            ResidentialAddress = "Residential Address",


        }

        public enum InvoiceStatus
        {
            Paid = "Paid",
            Due = "Due"
        }

        public enum CustomerType
        {
            Wholesale = "Wholesale",
            Retail = "Retail"
        }


        public enum SupplierType
        {
            Wholesale = "Wholesale",
            Retail = "Retail"
        }
    }
}
