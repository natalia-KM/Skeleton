using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsStock
        clsStock AStock = new clsStock();
        //receives the data from the session object
        AStock = (clsStock) Session["AStock"];

        //outputs the data for this entry
        Response.Write("Product No: " + AStock.ProductNo + " ");
        Response.Write("Product Description: " + AStock.ProductDescription + " ");
        Response.Write("Date Added: " + AStock.DateAdded + " ");
        Response.Write("Size: " + AStock.Size + " ");
        Response.Write("Type: " + AStock.Type + " ");
        Response.Write("Stock: " + AStock.Stock + " ");
        Response.Write("Price: " + AStock.Price + " ");
    }
}