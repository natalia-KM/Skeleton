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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the ListBox control for Orders
        if (lstOrderList.SelectedIndex != -1) //allows us to make sure that an entry on the listbox has been clicked/selected
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue); //SelectedValue property holds primary key value of the selected record in the listbox
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the Orders list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the ListBox control for Orders
        if (lstOrderList.SelectedIndex != -1) //allows us to make sure that an entry on the listbox has been clicked/selected
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue); //SelectedValue property holds primary key value of the selected record in the listbox
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the Orders list";
        }
    }

    protected void btnEdit_OrderLine_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        if (txtOrderDateFilter.Text != "")
        {
            clsOrderCollection Orders = new clsOrderCollection();
            Orders.ReportByOrderDate(Convert.ToDateTime(txtOrderDateFilter.Text));
            lstOrderList.DataSource = Orders.OrderList;
            //set the name of the primary key
            lstOrderList.DataValueField = "OrderID";
            //set the name of the field to display
            lstOrderList.DataTextField = "OrderDate";
            //bind the data to the list
            lstOrderList.DataBind();
        } 
        else
        {
            lblError.Text = "Please enter a date before applying the filter.";
        }
    }

    // clear button removes filter
    //so begin displaying orders by their date just like it was presented
    // prior to pressing the apply filter button
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Orders.ReportByCustomerID(-1);
        //clear any existing filter to tidy up the interface
        txtOrderDateFilter.Text = "";
        DisplayOrders();
    }

    protected void btnCheckOrderID_Click(object sender, EventArgs e)
    {
        btnCheckOrderID.Text = "Check Selected Order's OrderID " + "(ID is " + lstOrderList.SelectedValue + ")";
    }
}