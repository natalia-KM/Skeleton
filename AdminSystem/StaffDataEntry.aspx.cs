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
        string EmployeeName = txtEmployeeName.Text;
        string EmployeeEmail = txtEmployeeEmail.Text;
        string EmployeePosition = txtEmployeePosition.Text;
        string EmployeeSalary = txtEmployeeSalary.Text;
        string EmployeeStartDate = txtEmployeeStartDate.Text;

        string Error = "";
        Error = staff.Valid(EmployeeName, EmployeePosition, EmployeeEmail, EmployeeSalary, EmployeeStartDate);

        if(Error == "")
        {
            staff.EmployeeName = EmployeeName;
            staff.EmployeeEmail = EmployeeEmail;
            staff.EmployeePosition = EmployeePosition;
            staff.EmployeeSalary = Convert.ToDouble(EmployeeSalary);
            staff.EmployeeStartDate = DateTime.Parse(EmployeeStartDate);
            staff.BonusEligible = CheckBoxBonus.Checked;


            clsStaffCollection allStaff = new clsStaffCollection();
            allStaff.ThisEmployee = staff;
            allStaff.Add();

            Response.Redirect("StaffList.aspx");
        } 
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        Int32 EmployeeID;
        Boolean Found = false;
        EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
        Found = staff.Find(EmployeeID);

        if(Found == true)
        {
            txtEmployeeID.Text = Convert.ToString(staff.EmployeeID);
            txtEmployeeName.Text = staff.EmployeeName;
            txtEmployeePosition.Text = staff.EmployeePosition;
            txtEmployeeEmail.Text = staff.EmployeeEmail;
            txtEmployeeStartDate.Text = staff.EmployeeStartDate.ToString();
            txtEmployeeSalary.Text = staff.EmployeeSalary.ToString();
            CheckBoxBonus.Checked = staff.BonusEligible;

        }
    }

}