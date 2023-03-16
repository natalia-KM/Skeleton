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

        //stores all the values from the text boxes into variables
        string ProductDescription = txtProductDescription.Text;
        string DateAdded = txtDateAdded.Text;
        string Size = txtSize.Text;
        string Type = txtType.Text;
        string Stock = txtStock.Text;
        string Price = txtPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validates data based on the variables
        Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
        if(Error == "")
        {
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
            //redirects you to the 'StockViewer' page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creates an instance of the stock class
        clsStock Stock = new clsStock();
        //create the variable ProductNo (Primary Key)
        Int32 ProductNo;
        //boolean variable to store the result of the find operation
        Boolean Found = false;
        //collects the primary key inputted by the user
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        //uses find to find the record related to the inputted ProductNo
        Found = Stock.Find(ProductNo);
        //if the ProductNo was found
        if(Found == true)
        {
            //displays the values from the table record
            txtProductDescription.Text = Stock.ProductDescription;
            txtDateAdded.Text = Stock.DateAdded.ToString();
            txtSize.Text = Stock.Size;
            txtType.Text = Stock.Type;
            txtStock.Text = Stock.Stock.ToString();
            txtPrice.Text = Stock.Price.ToString();
        }
    }
}