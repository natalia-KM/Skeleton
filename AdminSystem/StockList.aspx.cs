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
        if(IsPostBack == false)
        {
            //updates the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list the products in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductNo";
        //set the data field to display
        lstStockList.DataTextField = "ProductDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}