using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.FullName = txtFullName.Text;
        ACustomer.Email = txtEmail.Text;
        ACustomer.PhoneNumber = txtPhoneNumber.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        ACustomer.TotalSpent = Convert.ToDouble(txtTotalSpent.Text);
        ACustomer.PaymentDataAdded = chkPaymentDataAdded.Checked;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");

    }
}