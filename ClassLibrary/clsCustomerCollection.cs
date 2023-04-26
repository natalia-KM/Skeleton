using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@TotalSpent", mThisCustomer.TotalSpent);
            DB.AddParameter("@PaymentDataAdded", mThisCustomer.PaymentDataAdded);
            //execute query returning primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@TotalSpent", mThisCustomer.TotalSpent);
            DB.AddParameter("@PaymentDataAdded", mThisCustomer.PaymentDataAdded);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial full name value
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@FullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
                //populates the array list based on the data table in the parameter DB
                //var for the index
                Int32 Index = 0;
                //var to store the record count
                Int32 RecordCount = 0;
                //get the count of records
                RecordCount = DB.Count;
                //clear the private array list
                mCustomerList = new List<clsCustomer>();
                //while there are records to process
                while (Index < RecordCount) // starts from index 0 which is row 0, that's the first row.
                {
                    //create a blank Customer object
                    clsCustomer ACustomer = new clsCustomer();
                    //read in the fields from the current record
                    ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    ACustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                    ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    ACustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                    ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                    ACustomer.TotalSpent = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalSpent"]);
                    ACustomer.PaymentDataAdded = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentDataAdded"]);
                    //add the record to the private data member list.
                    mCustomerList.Add(ACustomer);
                    //increment the index, to point to the next record.
                    Index++;
                }
            
        }
    }
}
