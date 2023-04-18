using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["EmployeeID"]);
 
        if (IsPostBack == false)
        {
            if(EmployeeID != -1)
            {
                DisplayStaff();
            }
        }
    }


    void DisplayStaff()
    {
        clsStaff staff = new clsStaff();
        txtEmployeeID.Text = EmployeeID.ToString();
  
        staff.Find(EmployeeID);

        
            txtEmployeeID.Text = Convert.ToString(staff.EmployeeID);
            txtEmployeeName.Text = staff.EmployeeName;
            txtEmployeePosition.Text = staff.EmployeePosition;
            txtEmployeeEmail.Text = staff.EmployeeEmail;
            txtEmployeeStartDate.Text = staff.EmployeeStartDate.ToString();
            txtEmployeeSalary.Text = staff.EmployeeSalary.ToString();
            CheckBoxBonus.Checked = staff.BonusEligible;

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
            staff.EmployeeID = EmployeeID;
            staff.EmployeeName = EmployeeName;
            staff.EmployeeEmail = EmployeeEmail;
            staff.EmployeePosition = EmployeePosition;
            staff.EmployeeSalary = Convert.ToDouble(EmployeeSalary);
            staff.EmployeeStartDate = DateTime.Parse(EmployeeStartDate);
            staff.BonusEligible = CheckBoxBonus.Checked;


            clsStaffCollection allStaff = new clsStaffCollection();

            if(EmployeeID == -1)
            {
                allStaff.ThisEmployee = staff;
                allStaff.Add();
            } else
            {
                allStaff.ThisEmployee.Find(EmployeeID);
                allStaff.ThisEmployee = staff;
                allStaff.Update();
            }
           

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
        if (txtEmployeeID.Text.Length != 0)
        {

            EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            Found = staff.Find(EmployeeID);

            if (Found == true)
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

}