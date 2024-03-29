﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        // capturing the data
        string FullName = txtFullName.Text;
        string Email = txtEmail.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string TotalSpent = txtTotalSpent.Text;
        // variable to store any error messages
        string Error = "";
        // Validate the data
        Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
        if (txtDateOfBirth.Text != "")
        {
            if (Convert.ToDateTime(DateOfBirth).Year < DateTime.Now.Year)
            {
                if (DateTime.Now.Year - Convert.ToDateTime(DateOfBirth).Year < 14)
                {
                    //record the error
                    Error += "You must be 14 or over." + "<br />";
                }
            }
        } 
        else
        {
            Error += "Please input a date of birth" + "<br />";
        }
        if (Error == "")
        {
            ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            ACustomer.FullName = txtFullName.Text;
            ACustomer.Email = txtEmail.Text;
            ACustomer.PhoneNumber = txtPhoneNumber.Text;
            ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            ACustomer.TotalSpent = Convert.ToDouble(txtTotalSpent.Text);
            ACustomer.PaymentDataAdded = chkPaymentDataAdded.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is new record i.e. CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                //add new record
                CustomerList.Add();
            }
            //otherwise it must be update
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            lblError.Text = "";
            txtFullName.Text = ACustomer.FullName.ToString();
            txtEmail.Text = ACustomer.Email.ToString();
            txtPhoneNumber.Text = ACustomer.PhoneNumber.ToString();
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtTotalSpent.Text = ACustomer.TotalSpent.ToString();
            chkPaymentDataAdded.Checked = ACustomer.PaymentDataAdded;
        }
        else
        {
            lblError.Text = "CustomerID " + txtCustomerID.Text + " not found";
        }
    }

    public void DisplayCustomers()
    {
        clsCustomerCollection CustomerCollection = new clsCustomerCollection();
        CustomerCollection.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = CustomerCollection.ThisCustomer.CustomerID.ToString();
        txtFullName.Text = CustomerCollection.ThisCustomer.FullName;
        txtEmail.Text = CustomerCollection.ThisCustomer.Email;
        txtPhoneNumber.Text = CustomerCollection.ThisCustomer.PhoneNumber;
        txtDateOfBirth.Text = CustomerCollection.ThisCustomer.DateOfBirth.ToString();
        txtTotalSpent.Text = CustomerCollection.ThisCustomer.TotalSpent.ToString();
        chkPaymentDataAdded.Checked = CustomerCollection.ThisCustomer.PaymentDataAdded;
    }
}