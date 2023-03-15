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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderCost = Convert.ToDouble(DB.DataTable.Rows[0]["OrderCost"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
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

        public string Valid(string orderDate, string orderCost, string customerID, string notes, string orderQuantity)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //copy the orderDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(orderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The OrderDate cannot be in the past ; ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The OrderDate cannot be in the future ; ";
            }
            //return any error messages
            return Error;
        }
    }
}