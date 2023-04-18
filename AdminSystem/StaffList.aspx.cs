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

        if(IsPostBack == false)
        {
                DisplayStaff();
   
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection allStaff = new clsStaffCollection();
        lstStaffList.DataSource = allStaff.StaffList;
        lstStaffList.DataValueField = "EmployeeID"; //set the name of primary key
        lstStaffList.DataTextField = "EmployeeName"; // set data field to display
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //indicate this is a new record
        Session["EmployeeID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;

        if(lstStaffList.SelectedIndex!=-1)
        {
            EmployeeID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("StaffDataEntry.aspx");
        } else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;

        if(lstStaffList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("StaffConfirmDelete.aspx");
        } else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}