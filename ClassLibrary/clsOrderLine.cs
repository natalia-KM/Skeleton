namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderLineNo { get; set; }
        public int OrderID { get; set; }
        public int ProductNo { get; set; }
        public string ProductDescription { get; set; }
        public int ItemQuantity { get; set; }
        public double TotalCost { get; set; }
    }
}