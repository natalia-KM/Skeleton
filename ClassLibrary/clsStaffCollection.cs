using System;
using System.Collections.Generic;

namespace ClassLibrary
    

{
    public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisEmployee = new clsStaff();

        public clsStaffCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);

        }


        
        public List<clsStaff> StaffList { 
            get 
            {
                return mStaffList;
            } set 
            { 
                mStaffList = value; 
            } 
        }



        public clsStaff ThisEmployee
        {
            get
            {
                return mThisEmployee;
            }
            set
            {
                mThisEmployee = value;
            }
        }
        public int Count { 
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeName", mThisEmployee.EmployeeName);
            DB.AddParameter("@EmployeePosition", mThisEmployee.EmployeePosition);
            DB.AddParameter("@EmployeeEmail", mThisEmployee.EmployeeEmail);
            DB.AddParameter("@EmployeeStartDate", mThisEmployee.EmployeeStartDate);
            DB.AddParameter("@EmployeeSalary", mThisEmployee.EmployeeSalary);
            DB.AddParameter("@BonusEligible", mThisEmployee.BonusEligible);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.AddParameter("@EmployeeName", mThisEmployee.EmployeeName);
            DB.AddParameter("@EmployeePosition", mThisEmployee.EmployeePosition);
            DB.AddParameter("@EmployeeEmail", mThisEmployee.EmployeeEmail);
            DB.AddParameter("@EmployeeStartDate", mThisEmployee.EmployeeStartDate);
            DB.AddParameter("@EmployeeSalary", mThisEmployee.EmployeeSalary);
            DB.AddParameter("@BonusEligible", mThisEmployee.BonusEligible);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeName", Name);
            DB.Execute("sproc_tblStaff_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while(Index < RecordCount)
            {
                clsStaff staff = new clsStaff();

                staff.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeID"]);
                staff.EmployeeName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeName"]);
                staff.EmployeePosition = Convert.ToString(DB.DataTable.Rows[Index]["EmployeePosition"]);
                staff.EmployeeEmail = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeEmail"]);
                staff.EmployeeSalary = Convert.ToDouble(DB.DataTable.Rows[Index]["EmployeeSalary"]);
                staff.EmployeeStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmployeeStartDate"]);
                staff.BonusEligible = Convert.ToBoolean(DB.DataTable.Rows[Index]["BonusEligible"]);

                mStaffList.Add(staff);

                Index++;
            }
        }
    }
}