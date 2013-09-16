using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class TransactionObject
    {
        public TransactionObject()
        { }

        private int stock_code;

        public int Stock_Code
        {
            get { return stock_code; }
            set { stock_code = value; }
        }

        private int account_id;

        public int Account_ID
        {
            get { return account_id; }
            set { account_id = value; }
        }

        private string transaction_type;

        public string Transaction_Type
        {
            get { return transaction_type; }
            set { transaction_type = value; }
        }

        private DateTime transaction_date;

        public DateTime Transaction_Date
        {
            get { return transaction_date; }
            set { transaction_date = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private decimal vat_amount;

        public decimal Vat_Amount
        {
            get { return vat_amount; }
            set { vat_amount = value; }
        }

    }
}
