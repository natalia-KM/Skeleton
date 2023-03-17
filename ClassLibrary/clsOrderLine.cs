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

        public string Valid(string orderID, string productNo, string productDescription, string itemQuantity, string totalCost)
        {
            //create a string variable to store the error
            String Error = "";

            // ORDER ID
            //create a temporary variable to store integer value
            Int32 OrderIDTemp;
            try
            {
                OrderIDTemp = Convert.ToInt32(orderID);
                //check to see if the OrderID value is less than 1 (does it meet the minimum value)
                if (OrderIDTemp < 1)
                {
                    //record the error
                    Error += "The OrderID cannot be below 1 ; ";
                }
                //check to see if the CustomerID value is greater than the max value an integer Int32 variable can store.
                if (OrderIDTemp > Int32.MaxValue)
                {
                    //record the error
                    Error += "The OrderID cannot be greater than max value of an integer ; ";
                }
            }
            catch
            {
                //record the error
                Error += "The OrderID is invalid or blank : ";
            }


            // PRODUCT NO
            //create a temporary variable to store integer value
            Int32 ProductNoTemp;
            try
            {
                ProductNoTemp = Convert.ToInt32(productNo);
                //check to see if the ProductNo value is less than 1 (does it meet the minimum value)
                if (ProductNoTemp < 1)
                {
                    //record the error
                    Error += "The ProductNo cannot be below 1 ; ";
                }
                //check to see if the ProductNo value is greater than the max value an integer Int32 variable can store.
                if (ProductNoTemp > Int32.MaxValue)
                {
                    //record the error
                    Error += "The ProductNo cannot be greater than max value of an integer ; ";
                }
            }
            catch
            {
                //record the error
                Error += "The ProductNo is invalid or blank : ";
            }


            // PRODUCT DESCRIPTION
            //if the ProductDescription variable has string contents that exceed the maximum amount of characters.
            if (productDescription.Length > 50)
            {
                //record the error
                Error += "ProductDescription field has a character amount exceeding the maximum amount of 50";
            }
            //if the ProductDescription variable has string contents of character length that is less than the minimum amount (1 character). - this field cannot be blank.
            if (productDescription.Length < 1)
            {
                //record the error
                Error += "ProductDescription field cannot be blank";
            }


            // ITEM QUANTITY
            //create a temporary variable to store integer value
            Int32 ItemQuantityTemp;
            try
            {
                ItemQuantityTemp = Convert.ToInt32(itemQuantity);
                //check to see if the ItemQuantity value is less than 1 (does it meet the minimum value)
                if (ItemQuantityTemp < 1)
                {
                    //record the error
                    Error += "The ItemQuantity cannot be below 1 ; ";
                }
                //check to see if the ItemQuantity value is greater than the max value an integer Int32 variable can store.
                if (ItemQuantityTemp > Int32.MaxValue)
                {
                    //record the error
                    Error += "The ItemQuantity cannot be greater than max value of an integer ; ";
                }
            }
            catch
            {
                //record the error
                Error += "The ItemQuantity is invalid or blank : ";
            }


            // TOTAL COST
            //create a temporary variable to store decimal/double values
            Decimal TotalCostTemp;
            try
            {
                //copy the totalCost value to the TotalCostTemp variable
                TotalCostTemp = Convert.ToDecimal(totalCost);
                if (TotalCostTemp < 0)
                {
                    //record the error
                    Error += "The TotalCost cannot be below 0.00 ; ";
                }
                //check to see if the decimal value is greater than the max value a decimal variable can store
                if (TotalCostTemp > Decimal.MaxValue)
                {
                    //record the error
                    Error += "The TotalCost cannot be above the maximum value of a decimal; ";
                }
            }
            catch
            {
                //record the error
                Error = Error += "The TotalCost was not a valid amount : ";
            }


            //return any error messages
            return Error;
        }
    }
}