using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }
        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        private double mTotalSpent;
        public double TotalSpent
        {
            get
            {
                return mTotalSpent;
            }
            set
            {
                mTotalSpent = value;
            }
        }
        private Boolean mPaymentDataAdded;
        public bool PaymentDataAdded
        {
            get
            {
                return mPaymentDataAdded;
            }
            set
            {
                mPaymentDataAdded = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mTotalSpent = Convert.ToDouble(DB.DataTable.Rows[0]["TotalSpent"]);
                mPaymentDataAdded = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentDataAdded"]);
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

        public string Valid(string fullName, string email, string phoneNumber, string dateOfBirth, string totalSpent)
        {
            //create a string variable to store the error
            String Error = "";

            // FULL NAME TESTS
            if (fullName.Length > 50)
            {
                //record the error
                Error += "Full Name Length too large (max 50 characters)" + "<br />";
            }
            if (fullName.Length < 1)
            {
                //record the error
                Error += "Full Name field cannot be blank" + "<br />";
            }

            // EMAIL TESTS
            if (email.Length > 50)
            {
                //record the error
                Error += "Email too large (max 50 characters)" + "<br />";
            }
            if (email.Length < 1)
            {
                //record the error
                Error += "Email cannot be blank" + "<br />";
            }
            if (!email.Contains("@"))
            {
                if (email == "")
                {
                    Error += "Email cannot be blank" + "<br />";
                }
                else
                {
                    //record the error
                    Error += "Email must have @ character" + "<br />";
                }   
            }

            // PHONE NUMBER TESTS
            if (phoneNumber.Length > 15)
            {
                //record the error
                Error += "Phone Number too large (max 15 characters)" + "<br />";
            }
            if (phoneNumber.Length < 5)
            {
                //record the error
                phoneNumber += "Invalid phone number (must be bigger than 5 characters)" + "<br />";
            }
            if (!phoneNumber.Contains("+"))
            {
                if (phoneNumber == "")
                {
                    Error += "Phone Number field cannot be blank" + "<br />";
                }
                else
                {
                    //record the error
                    Error += "Phone Number must have '+' character" + "<br />";
                }
            }

            // DATE OF BIRTH TESTS
            DateTime DateOfBirthTemp;
            try
            {
                DateOfBirthTemp = Convert.ToDateTime(dateOfBirth);
                if (DateOfBirthTemp < Convert.ToDateTime("01/01/1900"))
                {
                    //record the error
                    Error += "Your date of birth is not eligible" + "<br />";
                }
                if (DateOfBirthTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error += "Your date of birth is not eligible" + "<br />";
                }
                /*
                if (DateTime.Now.Year - DateOfBirthTemp.Year < 14)
                {
                    //record the error
                    Error += "You must be 14 or over.";
                }
                */
            }
            catch
            {
                Error += "Your date of birth is invalid" + "<br />";
            }

            // TOTAL SPENT TESTS
            Decimal TotalSpentTemp;
            try
            {
                //copy the totalSpent value to the TotalSpentTemp variable
                TotalSpentTemp = Convert.ToDecimal(totalSpent);
                if (TotalSpentTemp < 0)
                {
                    //record the error
                    Error += "The TotalSpent field cannot be below 0.00" + "<br />";
                }
                //check to see if the decimal value is greater than the max value a decimal variable can store
                if (TotalSpentTemp > Decimal.MaxValue)
                {
                    //record the error
                    Error += "The TotalSpent field cannot be above the maximum value of a decimal" + "<br />";
                }
            }
            catch
            {
                //record the error
                Error = Error += "The TotalSpent entered was not a valid amount" + "<br />";
            }

            // return errors
            return Error;
        }
    }
}