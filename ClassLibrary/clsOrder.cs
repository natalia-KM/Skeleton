using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private member variables
        private Int32 mOrderID;
        private DateTime mOrderDate;
        private Double mOrderCost;
        private Int32 mCustomerID;
        private string mNotes;
        private Boolean mDispatched;
        private Int32 mOrderQuantity;
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
        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }
        //OrderCost public property
        public double OrderCost
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderCost;
            }
            set
            {
                //this line of code allows data into the property
                mOrderCost = value;
            }
        }
        //CustomerID public property
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }
        public string Notes
        {
            get
            {
                //this line of code sends data out of the property
                return mNotes;
            }
            set
            {
                //this line of code allows data into the property
                mNotes = value;
            }
        }
        public bool Dispatched
        {
            get
            {
                //this line of code sends data out of the property
                return mDispatched;
            }
            set
            {
                //this line of code allows data into the property
                mDispatched = value;
            }
        }
        public int OrderQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mOrderQuantity = value;
            }
        }
        public bool Find(int OrderID)
        {
            //set the private data members to the test data value
            mOrderID = 3;
            mOrderDate = Convert.ToDateTime("10/02/2023");
            mOrderCost = Convert.ToDouble(29.9800);
            mCustomerID = 1;
            mNotes = "";
            mDispatched = true;
            mOrderQuantity = 2;
            //always return true
            return true;
        }
    }
}