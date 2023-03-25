using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        //private data members for OrderLineList, Count
        private List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();

        // public properties for OrderLineList, Count
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                //return the private data
                return mOrderLineList;
            }
            set
            {
                //set the private data
                mOrderLineList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderLineList.Count;
            }
            set
            {
                // we will worry about this later
            }
        }
        public clsOrderLine ThisOrderLine { get; set; }


        //constructor for the class
        public clsOrderLineCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //get the count of records in the database, store in RecordCount variable
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) // starts from index 0 which is row 0, that's the first row.
            {
                //create a blank OrderLine object
                clsOrderLine AnOrderLine = new clsOrderLine();
                //read in the fields from the current record (from the database)
                AnOrderLine.OrderLineNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineNo"]);
                AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                AnOrderLine.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnOrderLine.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrderLine.TotalCost = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalCost"]);
                //add the record to the private data member list.
                mOrderLineList.Add(AnOrderLine);
                //increment the index, to point to the next record.
                Index++;
            }
        }
    }
}