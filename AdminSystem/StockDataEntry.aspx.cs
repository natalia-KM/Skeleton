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
    Int32 ProductNo;
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
            AStock.ProductNo = ProductNo;
            AStock.ProductDescription = ProductDescription;
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            AStock.Size = Size;
            AStock.Type = Type;
            AStock.Stock = Convert.ToInt32(Stock);
            AStock.Price = Convert.ToDouble(Price);

            //creates a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            
            //if this is a new record it will add the data
            if (ProductNo == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //else if must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductNo);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //updates the record
                StockList.Update();
            }
      
            //redirects you to the 'StockList' page
            Response.Redirect("StockList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}