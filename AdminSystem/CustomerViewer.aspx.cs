﻿using System;
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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write("CustomerID: " + ACustomer.CustomerID + "<br>Full Name: " + ACustomer.FullName + "<br>Email: " + ACustomer.Email +
            "<br>Phone Number: " + ACustomer.PhoneNumber + "<br>Date Of Birth: " + ACustomer.DateOfBirth + "<br>Total Spent: " + ACustomer.TotalSpent +
            "<br>Payment Data Added: " + ACustomer.PaymentDataAdded);
    }
}