﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class SupplierObject
    {
        public SupplierObject()
        { }

    private string Supplier_Name;

    public string Supplier_NameProp
        {
            get { return Supplier_Name; }
            set { Supplier_Name = value; }
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
       
        private string VAT_Number;

        public string VAT_NumberProp
        {
            get { return VAT_Number; }
            set { VAT_Number = value; }
        }
        private string Representative;

        public string RepresentativeProp
        {
            get { return Representative; }
            set { Representative = value; }
        }
        private string CK_Number;

        public string CK_NumberProp
        {
            get { return CK_Number; }
            set { CK_Number = value; }
        }
        private bool Disable;

        public bool DisableProp
        {
            get { return Disable; }
            set { Disable = value; }
        }

        private bool Wholesale_Supplier;

        public bool Wholesale_SupplierProp
        {
            get { return Wholesale_Supplier; }
            set { Wholesale_Supplier = value; }
        }

        
    }
}
