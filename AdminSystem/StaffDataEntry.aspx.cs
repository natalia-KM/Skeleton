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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        staff.EmployeeName = txtEmployeeName.Text;
        staff.EmployeeEmail = txtEmployeeEmail.Text;
        staff.EmployeePosition = txtEmployeePosition.Text;
        staff.EmployeeSalary = Convert.ToDouble(txtEmployeeSalary.Text);
        staff.EmployeeStartDate = DateTime.Parse(txtEmployeeStartDate.Text);
        staff.BonusEligible = CheckBoxBonus.Checked;

        Session["staff"] = staff;
        Response.Redirect("StaffViewer.aspx");
    }
}