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
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session object to indicate new record
        Session["CustomerID"] = -1;
        //redirect to data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        // if record selected from list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value of record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in session object
            Session["CustomerID"] = CustomerID;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record selected in list box 
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        //if a record has been selected from the list 
        if (lstCustomerList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
            //create an instance of the customer collection
            clsCustomerCollection CustomerCollection = new clsCustomerCollection();
            CustomerCollection.ReportByFullName(Convert.ToString(txtFullNameFilter.Text));
            lstCustomerList.DataSource = CustomerCollection.CustomerList;
            //set the name of the primary key
            lstCustomerList.DataValueField = "CustomerID";
            //set the name of the field to display
            lstCustomerList.DataTextField = "FullName";
            //bind the data to the list
            lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection CustomerCollection = new clsCustomerCollection();
        CustomerCollection.ReportByFullName("");
        //clear any existing filter to tidy up the interface
        txtFullNameFilter.Text = "";
        lstCustomerList.DataSource = CustomerCollection.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "FullName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}