using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public static string Size { get; set; }
        public static string Type { get; set; }
        public static int Stock { get; set; }
        public static double Price { get; set; }
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
    }
}