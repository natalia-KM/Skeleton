using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mEmpID;
        public Int32 EmployeeID
        {
            get
            {
                return mEmpID;
            }
            set
            {
                mEmpID = value;
            }
        }

        private string mEmpName;
        public string EmployeeName
        {
            get
            {
                return mEmpName;
            }
            set
            {
                mEmpName = value;
            }
        }

        private string mEmpPosition;
        public string EmployeePosition
        {
            get
            {
                return mEmpPosition;
            }
            set
            {
                mEmpPosition = value;
            }
        }

        private string mEmpEmail;
        public string EmployeeEmail
        {
            get
            {
                return mEmpEmail;
            }
            set
            {
                mEmpEmail = value;
            }
        }

        private DateTime mEmpStartDate;
        public DateTime EmployeeStartDate
        {
            get
            {
                return mEmpStartDate;
            }
            set
            {
                mEmpStartDate = value;
            }
        }

        private double mEmpSalary;
        public double EmployeeSalary
        {
            get
            {
                return mEmpSalary;
            }
            set
            {
                mEmpSalary = value;
            }
        }

        private bool mBonusE;
        public bool BonusEligible
        {
            get
            {
                return mBonusE;
            }
            set
            {
                mBonusE = value;
            }
        }

        public bool Find(Int32 empID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", empID);
            DB.Execute("sproc_tblStaff_FilterByEmployeeID");

            if(DB.Count==1)
            {
                mEmpID = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeID"]);
                mEmpName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeName"]);
                mEmpPosition = Convert.ToString(DB.DataTable.Rows[0]["EmployeePosition"]);
                mEmpEmail = Convert.ToString(DB.DataTable.Rows[0]["EmployeeEmail"]);
                mEmpStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EmployeeStartDate"]);
                mEmpSalary = Convert.ToDouble(DB.DataTable.Rows[0]["EmployeeSalary"]);
                mBonusE = Convert.ToBoolean(DB.DataTable.Rows[0]["BonusEligible"]);
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
