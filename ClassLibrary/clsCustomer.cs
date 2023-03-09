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
            mCustomerID = 1;
            mFullName = "Stefan Calarasu";
            mEmail = "stefcsu@gmail.com";
            mPhoneNumber = "07388596274";
            mDateOfBirth = Convert.ToDateTime("23/12/1987");
            mTotalSpent = 29.98;
            mPaymentDataAdded = true;
            return true;
        }
    }
}