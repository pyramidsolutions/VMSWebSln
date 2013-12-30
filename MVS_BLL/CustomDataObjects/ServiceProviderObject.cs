using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class ServiceProviderObject
    {
        public ServiceProviderObject()
        { }

        private int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        private string sp_address;

        public string SP_address
        {
            get { return sp_address; }
            set { sp_address = value; }
        }

        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private bool disable;

        public bool Disable
        {
            get { return disable; }
            set { disable = value; }
        }

        private string sp_name;

        public string SP_Name
        {
            get { return sp_name; }
            set { sp_name = value; }
        }
    }
}
