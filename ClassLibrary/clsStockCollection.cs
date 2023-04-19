using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            //variable to stores the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProducts_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while loop for the records to process
            while (Index < RecordCount)
            {
                //creates a new instance of clsStock
                clsStock Stock = new clsStock();
                //read in the fields from the current record
                Stock.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Stock.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                Stock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                Stock.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                Stock.Type = Convert.ToString(DB.DataTable.Rows[Index]["Type"]);
                Stock.Stock = Convert.ToInt32(DB.DataTable.Rows[Index]["Stock"]);
                Stock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mStockList.Add(Stock);
                //increments to go to the next record
                Index++;          
            }
        }


        //private data meember for the list
        List<clsStock> mStockList = new List<clsStock>();
        //creates a new instance for the private data member
        clsStock mThisStock = new clsStock();
        //public property for StockList
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //...   
            }
        }

        //public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStock
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prcedure
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Type", mThisStock.Type);
            DB.AddParameter("@Stock", mThisStock.Stock);
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProducts_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prcedure
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Type", mThisStock.Type);
            DB.AddParameter("@Stock", mThisStock.Stock);
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the stored procedure
            DB.Execute("sproc_tblProducts_Update");
        }
    }
}