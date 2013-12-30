using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class CompanyObject
    {
        private string Company_Name;

        public string Company_NameProp
        {
            get { return Company_Name; }
            set { Company_Name = value; }
        }
        private string Address_Line_1;

        public string Address_Line_1Prop
        {
            get { return Address_Line_1; }
            set { Address_Line_1 = value; }
        }
        private string Address_Line_2;

        public string Address_Line_2Prop
        {
            get { return Address_Line_2; }
            set { Address_Line_2 = value; }
        }
        private string City;

        public string CityProp
        {
            get { return City; }
            set { City = value; }
        }
        private string Code;
        public string CodeProp
        {
            get { return Code; }
            set { Code = value; }
        }
        private string Telephone1;

        public string Telephone1Prop
        {
            get { return Telephone1; }
            set { Telephone1 = value; }
        }
        private string Telephone2;
        public string Telephone2Prop
        {
            get { return Telephone2; }
            set { Telephone2 = value; }
        }
        private string Cellphone;
        public string Cellphone1Prop
        {
            get { return Cellphone; }
            set { Cellphone = value; }
        }
        private string Fax;

        public string FaxProp
        {
            get { return Fax; }
            set { Fax = value; }
        }
        private string Email;

        public string EmailProp
        {
            get { return Email; }
            set { Email = value; }
        }
        private string Website;

        public string WebsiteProp
        {
            get { return Website; }
            set { Website = value; }
        }
        private string VAT_Number;

        public string VAT_NumberProp
        {
            get { return VAT_Number; }
            set { VAT_Number = value; }
        }
        private int VAT_percentage;

        public int VAT_percentageProp
        {
            get { return VAT_percentage; }
            set { VAT_percentage = value; }
        }
        private string Invoice_Footer;

        public string Invoice_FooterProp
        {
            get { return Invoice_Footer; }
            set { Invoice_Footer = value; }
        }
        private bool Disable;

        public bool DisableProp
        {
            get { return Disable; }
            set { Disable = value; }
        }

        private byte[] Company_Logo;

        public byte[] Company_LogoProp
        {
            get { return Company_Logo; }
            set { Company_Logo = value; }
        }
    }
}
