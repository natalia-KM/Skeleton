using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data members, for the list, count
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private int mCount;

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
        public clsOrder ThisOrder { get; set; }
    }
}