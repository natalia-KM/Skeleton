using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderCost { get; set; }
        public int CustomerID { get; set; }
        public string Notes { get; set; }
        public bool Dispatched { get; set; }
        public int OrderQuantity { get; set; }
    }
}