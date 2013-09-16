using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class UserObject
    {
        public UserObject()
        { }

        private string account_name;

        public string Account_Name
        {
            get { return account_name; }
            set { account_name = value; }
        }

        private string account_password;

        public string Account_Password
        {
            get { return account_password; }
            set { account_password = value; }
        }

        private string first_name;

        public string First_Name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string account_type;

        public string Account_Type
        {
            get { return account_type; }
            set { account_type = value; }
        }

        private int disable;

        public int Disable
        {
            get { return disable; }
            set { disable = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }






    }
}
