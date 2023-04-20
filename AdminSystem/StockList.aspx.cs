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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to show this is a new record
        Session["ProductNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }






    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 ProductNo;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record
            ProductNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductNo;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}