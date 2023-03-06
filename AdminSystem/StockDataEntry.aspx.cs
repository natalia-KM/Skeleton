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
        //creates a new instance of clsStock
        clsStock AStock = new clsStock();

        //captures the input from all textboxes
        AStock.ProductNo = Convert.ToInt32(txtProductNo.Text);
        AStock.ProductDescription = txtProductDescription.Text;
        AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AStock.Size = txtSize.Text;
        AStock.Type = txtType.Text;
        AStock.Stock = Convert.ToInt32(txtStock.Text);
        AStock.Price = Convert.ToDouble(txtPrice.Text);

        //store the stock in the session object
        Session["AStock"] = AStock;
        //Redirects you to the 'StockViewer' page
        Response.Redirect("StockViewer.aspx");
    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }
}