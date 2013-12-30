using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.CustomDataObjects
{
    public class VehicleObject
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

        private decimal cost_price;

        public decimal Cost_Price
        {
            get { return cost_price; }
            set { cost_price = value; }
        }

        private decimal retail_price;

        public decimal Retail_Price
        {
            get { return retail_price; }
            set { retail_price = value; }
        }

        private decimal wholesale_price;

        public decimal Wholesale_Price
        {
            get { return wholesale_price; }
            set { wholesale_price = value; }
        }

        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        private byte[] picture_1;

        public byte[] Picture_1
        {
            get { return picture_1; }
            set { picture_1 = value; }
        }

        private byte[] picture_2;

        public byte[] Picture_2
        {
            get { return picture_2; }
            set { picture_2 = value; }
        }

        private byte[] picture_3;

        public byte[] Picture_3
        {
            get { return picture_3; }
            set { picture_3 = value; }
        }

        private string chassis_number;

        public string Chassis_Number
        {
            get { return chassis_number; }
            set { chassis_number = value; }
        }

        private string engine_number;

        public string Engine_Number
        {
            get { return engine_number; }
            set { engine_number = value; }
        }

        private string registration_number;

        public string Registration_Number
        {
            get { return registration_number; }
            set { registration_number = value; }
        }

        private string extra_features;

        public string Extra_Features
        {
            get { return extra_features; }
            set { extra_features = value; }
        }

        private int mileage;

        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        private bool automatic_transmission;

        public bool Automatic_Transmission
        {
            get { return automatic_transmission; }
            set { automatic_transmission = value; }
        }

        private bool cor;

        public bool COR
        {
            get { return cor; }
            set { cor = value; }
        }

        private bool ac;

        public bool AC
        {
            get { return ac; }
            set { ac = value; }
        }

        private bool ci;

        public bool CI
        {
            get { return ci; }
            set { ci = value; }
        }

        private bool ps;

        public bool PS
        {
            get { return ps; }
            set { ps = value; }
        }

        private bool al;

        public bool AL
        {
            get { return al; }
            set { al = value; }
        }

        private bool leather;

        public bool Leather
        {
            get { return leather; }
            set { leather = value; }
        }

        private bool rt;

        public bool RT
        {
            get { return rt; }
            set { rt = value; }
        }

        private bool cd;

        public bool CD
        {
            get { return cd; }
            set { cd = value; }
        }

        private bool mp3;

        public bool MP3
        {
            get { return mp3; }
            set { mp3 = value; }
        }

        private bool fsh;

        public bool FSH
        {
            get { return fsh; }
            set { fsh = value; }
        }

        private bool sr;

        public bool SR
        {
            get { return sr; }
            set { sr = value; }
        }

        private bool sports_kit;

        public bool Sports_Kit
        {
            get { return sports_kit; }
            set { sports_kit = value; }
        }

        private bool airbag;

        public bool Airbag
        {
            get { return airbag; }
            set { airbag = value; }
        }

        private bool mags;

        public bool Mags
        {
            get { return mags; }
            set { mags = value; }
        }

        private bool gearlock;

        public bool Gearlock
        {
            get { return gearlock; }
            set { gearlock = value; }
        }

        private string condition;

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        private DateTime arrival_date;

        public DateTime Arrival_Date
        {
            get { return arrival_date; }
            set { arrival_date = value; }
        }

        private string vehicle_status;

        public string Vehicle_Status
        {
            get { return vehicle_status; }
            set { vehicle_status = value; }
        }
        //get transaction code in SP

        // get Improvement_ID in SP
        
    }
}
