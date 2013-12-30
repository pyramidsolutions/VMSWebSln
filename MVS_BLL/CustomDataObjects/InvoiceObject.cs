using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class InvoiceObject
    {
        public int InvoiceNumber { get; set; }

        public CompanyObject CompanyInfo { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime DueDate { get; set; }

        public MVS_Enum.CommonEnums.InvoiceStatus InvoiceStatus { get; set; }

        public List<TransactionObject> Transactions { get; set; }

        public decimal SubTotal { get; set; }

        public int Discount { get; set; }

        public decimal VATAmount { get; set; }

        public decimal GrandTotal { get; set; }

        public UserObject User { get; set; }

        public CustomerObject Customer { get; set; }

    }
}
