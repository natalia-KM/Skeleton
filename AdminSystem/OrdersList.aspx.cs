using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
            DisplayOrderLines();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderDate";
        //bind the data to the list
        lstOrderList.DataBind();
    }
    void DisplayOrderLines()
    {
        //create an instance of the OrderLine collection class
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        //set the data source to list of OrderLines in the collection
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        //set the name of the primary key
        lstOrderLineList.DataValueField = "OrderLineNo";
        //set the data field to display
        lstOrderLineList.DataTextField = "OrderID";
        //bind the data to the list
        lstOrderLineList.DataBind();
    }
}