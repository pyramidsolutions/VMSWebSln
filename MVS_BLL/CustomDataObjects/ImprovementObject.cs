﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    class ImprovementObject
    {
        public ImprovementObject()
        { }

        private string sp_name;

        public string SP_Name
        {
            get { return sp_name; }
            set { sp_name = value; }
        }

        private int stock_code;

        public int Stock_Code
        {
            get { return stock_code; }
            set { stock_code = value; }
        }

        private string improvement_description;

        public string Improvement_Description
        {
            get { return improvement_description; }
            set { improvement_description = value; }
        }

        private decimal improvement_price;

        public decimal Improvement_price
        {
            get { return improvement_price; }
            set { improvement_price = value; }
        }

        private string improvement_name;

        public string Improvement_Name
        {
            get { return improvement_name; }
            set { improvement_name = value; }
        }
    }
}