using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrders();
            }
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture data from all fields and store in corresponding string variables
        //this part is essentially preparing for the validation, since valid method
        //only accepts parameters of string type.
        string OrderDate = txtOrderDate.Text;
        string OrderCost = txtOrderCost.Text;
        string CustomerID = txtCustomerID.Text;
        string Notes = txtNotes.Text;
        string OrderQuantity = txtOrderQuantity.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
        if (Error == "") // contents of Error equating to blank "" means no errors, data is validated and good.
        {
            // validation was successful, data is good
            // Capture data that is entered in the textboxes
            AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.OrderCost = Convert.ToDouble(txtOrderCost.Text);
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.Notes = txtNotes.Text;
            AnOrder.Dispatched = chkDispatched.Checked;
            AnOrder.OrderQuantity = Convert.ToInt32(txtOrderQuantity.Text);
            //create a new instance of the Order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. OrderID = -1 then add the data
            if (OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties of the record with specific OrderID, in the form
            lblError.Text = "";
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderCost.Text = AnOrder.OrderCost.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtNotes.Text = AnOrder.Notes;
            chkDispatched.Checked = AnOrder.Dispatched;
            txtOrderQuantity.Text = AnOrder.OrderQuantity.ToString();
        }
        else
        {
            lblError.Text = "Record with OrderID " + txtOrderID.Text + " not found";
        }
    }
    void DisplayOrders()
    {
        //create an instance of the OrderCollection
        clsOrderCollection OrderCol = new clsOrderCollection();
        //find the record to update
        OrderCol.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderCol.ThisOrder.OrderID.ToString();
        txtOrderDate.Text = OrderCol.ThisOrder.OrderDate.ToString();
        txtOrderCost.Text = OrderCol.ThisOrder.OrderCost.ToString();
        txtCustomerID.Text = OrderCol.ThisOrder.CustomerID.ToString();
        txtNotes.Text = OrderCol.ThisOrder.Notes;
        chkDispatched.Checked = OrderCol.ThisOrder.Dispatched;
        txtOrderQuantity.Text = OrderCol.ThisOrder.OrderQuantity.ToString();

    }
}