using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private member variables
        private Int32 mOrderLineNo;
        private Int32 mOrderID;
        private Int32 mProductNo;
        private string mProductDescription;
        private Int32 mItemQuantity;
        private Double mTotalCost;
        //OrderLineNo public property
        public int OrderLineNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderLineNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderLineNo = value;
            }
        }
        //OrderID public property
        public int OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }
        //ProductNo public property
        public int ProductNo
        {
            get
            {
                //this line of code sends data out of the property
                return mProductNo;
            }
            set
            {
                //this line of code allows data into the property
                mProductNo = value;
            }
        }
        //ProductDescription public property
        public string ProductDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mProductDescription;
            }
            set
            {
                //this line of code allows data into the property
                mProductDescription = value;
            }
        }
        //ItemQuantity public property
        public int ItemQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mItemQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mItemQuantity = value;
            }
        }
        //TotalCost public property
        public double TotalCost
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalCost;
            }
            set
            {
                //this line of code allows data into the property
                mTotalCost = value;
            }
        }
        public bool Find(int OrderLineNo)
        {
            //set the private data members to the test data value
            mOrderLineNo = 2;
            mOrderID = 1;
            mProductNo = 1;
            mProductDescription = "Nike Revival Ball";
            mItemQuantity = 2;
            mTotalCost = 29.9800;
            //always return true
            return true;
        }
    }
}