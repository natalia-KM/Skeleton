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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderLineNo to search for
            DB.AddParameter("@OrderLineNo", OrderLineNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderLineNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineNo"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mTotalCost = Convert.ToDouble(DB.DataTable.Rows[0]["TotalCost"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicating a problem
                return false;
            }
        }
    }
}