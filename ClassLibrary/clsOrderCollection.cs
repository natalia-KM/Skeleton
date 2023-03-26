using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data members, for the list, count, ThisOrder
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private int mCount;
        private clsOrder mThisOrder = new clsOrder();

        // public properties for list, count
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }
       
        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records, store in RecordCount variable
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) // starts from index 0 which is row 0, that's the first row.
            {
                //create a blank Order object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderCost = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderCost"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                //add the record to the private data member list.
                mOrderList.Add(AnOrder);
                //increment the index, to point to the next record.
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderCost", mThisOrder.OrderCost);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@Notes", mThisOrder.Notes);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            //execute the query, returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}