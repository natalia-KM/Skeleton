using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }

        //This is a private member variable
        private Int32 mProductNo;
        //ProductNo public property
        public Int32 ProductNo 
        {
            get
            {
                //returns data out of the property
                return mProductNo;
            }
            set
            {
                //accepts data into the property
                mProductNo = value;
            }
        }

        //This is a private member variable
        private string mProductDescription;
        //ProductDescription public property
        public string ProductDescription
        {
            get
            {
                //returns data out of the property
                return mProductDescription;
            }
            set
            {
                //accepts data into the property
                mProductDescription = value;
            }
        }

        //This is a private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //returns data out of the property
                return mDateAdded;
            }
            set
            {
                //accepts data into the property
                mDateAdded = value;
            }
        }

        //This is a private member variable
        public string mSize;
        //Size public property
        public string Size
        {
            get
            {
                //returns data out of the property
                return mSize;
            }
            set
            {
                //accepts data into the property
                mSize = value;
            }
        }

        //This is a private member variable
        public string mType;
        //Type public property
        public string Type
        {
            get
            {
                //returns data out of the property
                return mType;
            }
            set
            {
                //accepts data into the property
                mType = value;
            }
        }

        //This is a private member variable
        public Int32 mStock;
        //Stock public property
        public Int32 Stock
        {
            get
            {
                //returns data out of the property
                return mStock;
            }
            set
            {
                //accepts data into the property
                mStock = value;
            }
        }

        //This is a private member variable
        public double mPrice;
        //Price public property
        public double Price
        {
            get
            {
                //returns data out of the property
                return mPrice;
            }
            set
            {
                //accepts data into the property
                mPrice = value;
            }
        }

        public bool Find(int productNo)
        {
            mProductNo = 3;
            mProductDescription = "Nike Revival Ball";
            mDateAdded = Convert.ToDateTime("09/02/2023");
            mSize = "7";
            mType = "Basketball";
            mStock = 50;
            mPrice = 14.99;
            return true;
        }
    }
}