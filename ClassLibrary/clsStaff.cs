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
            mEmpID = 1;
            mEmpName = "Natalia";
            mEmpPosition = "Manager";
            mEmpEmail = "nat@gmail.com";
            mEmpStartDate = Convert.ToDateTime("05/02/2023");
            mEmpSalary = 23000.0;
            mBonusE = false;
            return true;
        }
    }
}
