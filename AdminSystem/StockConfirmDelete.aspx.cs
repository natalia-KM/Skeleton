using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 ProductNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of ProductNo to be deleted from the session object
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //creates a new instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //finds the record to delete
        Stock.ThisStock.Find(ProductNo);
        //deletes the record
        Stock.Delete();
        //redirects back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirects back to the main page
        Response.Redirect("StockList.aspx");
    }
}