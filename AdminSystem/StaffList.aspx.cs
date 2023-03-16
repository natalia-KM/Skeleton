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
}