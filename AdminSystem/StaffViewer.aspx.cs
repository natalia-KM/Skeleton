using System;
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
        clsStaff staff = new clsStaff();
        staff = (clsStaff)Session["staff"];
        Response.Write("Name: " + staff.EmployeeName + "<br>Position: " + staff.EmployeePosition + "<br>Email: " + staff.EmployeeEmail + "<br>Salary:"
            + staff.EmployeeSalary + "<br>Start Date: " + staff.EmployeeStartDate + "<br>Bonus Eligible: " + staff.BonusEligible);
    
    }
}