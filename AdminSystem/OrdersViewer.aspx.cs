using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // Retrieve the data from the session obj
        AnOrder = (clsOrder) Session["AnOrder"];
        // Display all data of the Order obj, all properties.
        Response.Write("OrderID: " + AnOrder.OrderID + "<br>Order Date: " + AnOrder.OrderDate + "<br>Order Cost: " + AnOrder.OrderCost +
            "<br>CustomerID: " + AnOrder.CustomerID + "<br>Notes: " + AnOrder.Notes + "<br>Order Quantity: " + AnOrder.OrderQuantity +
            "<br>Dispatched: " + AnOrder.Dispatched);
        
        //Response.Write("OrderDate: " + AnOrder.OrderDate + " ");
        //Response.Write("OrderCost: " + AnOrder.OrderCost + " ");
        //Response.Write("CustomerID: " + AnOrder.CustomerID + " ");
        //Response.Write("Notes: " + AnOrder.Notes + " ");
        //Response.Write("OrderQuantity: " + AnOrder.OrderQuantity + " ");
        //Response.Write("Dispatched: " + AnOrder.Dispatched + " ");
 
    }
}