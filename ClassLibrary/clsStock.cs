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

        public bool Find(int ProductNo)
        {
            //creates an instance of DataConnection
            clsDataConnection DB = new clsDataConnection();
            //adds the parameter for the ProductNo for searching
            DB.AddParameter("@ProductNo", ProductNo);
            //executes the stored procedure
            DB.Execute("sproc_tblProducts_FilterByProductNo");
            
            //if a record is found it will add all the data into the private data members
            if(DB.Count == 1)
            {
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mType = Convert.ToString(DB.DataTable.Rows[0]["Type"]);
                mStock = Convert.ToInt32(DB.DataTable.Rows[0]["Stock"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);

                //when everything worked it returns true
                return true;
            }
            
            //if no record was found it will return false
            else
            {
                return false;
            }
        }

        public string Valid(string ProductDescription, string DateAdded, string Size, string Type, string Stock, string Price)
        {
            //creates a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the Product Description is blank
            if (ProductDescription.Length == 0)
            {
                //stores the error message into the string 'Error'
                Error += "The Product Description cannot be blank:";
            }
            //if the Product Description is greater than 51 characters
            if (ProductDescription.Length > 50)
            {
                //stores the error message into the string 'Error'
                Error += "The Product Description must be less than 51:";
            }

            //try - catch to add a error code for an invalid data type
            try
            {
                //changes DateAdded value into DateTime
                DateTemp = Convert.ToDateTime(DateAdded);
                //if the date is in the past
                if (DateTemp <= DateTime.Now.Date.AddYears(-100))
                {
                    //stores the error message into the string 'Error'
                    Error += "The date cannot be in the 100 years in the past :";
                }
                //if the date is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    //stores the error message into the string 'Error'
                    Error += "The date cannot be in the future :";
                }

            }
            catch
            {
                //stores the error message into the string 'Error'
                Error += "The date was not a valid date :";
            }

            //if the value is blank
            if (Size.Length == 0)
            {
                //stores the error message into the string 'Error'
                Error += "The size cannot be left blank :";
            }
            //if the value is greater than 10
            if (Size.Length > 10)
            {
                //stores the error message into the string 'Error'
                Error += "The size cannot be greater than 11 :";
            }

            //if the value is blank
            if (Type.Length == 0)
            {
                //stores the error message into the string 'Error'
                Error += Error + "The type cannot be left blank :";
            }
            //if the value is greater than 10
            if (Type.Length > 10)
            {
                //stores the error message into the string 'Error'
                Error += "The type cannot be greater than 11 :";
            }

            //try - catch to add a error code for an invalid data type
            try
            {
                //if the value is less than int32 max value
                if (Convert.ToInt32(Stock) > Int32.MaxValue)
                {
                    //stores the error message into the string 'Error'
                    Error += "The stock cannot be greater than Int32 max value :";
                }
            }
            catch
            {
                //stores the error message into the string 'Error'
                Error += "This is an invalid data type :";
            }

            //try - catch to add a error code for an invalid data type
            try
            {
                //if the product is free
                if (Convert.ToDouble(Price) == 0.0)
                {
                    //stores the error message into the string 'Error'
                    Error += "The price cannot be 0";
                }
                //if the price is higher than the max value
                if (Convert.ToDouble(Price) > Double.MaxValue)
                {
                    //stores the error message into the string 'Error'
                    Error += "The price cannot be greater than the double max value :";
                }
            }
            catch
            {
                Error += "This is an invalid data type";
            }

            //returns the error messages if found
            return Error;
        }

        
    }
}