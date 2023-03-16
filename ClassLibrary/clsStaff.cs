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

        public string Valid(string empName, string empPosition, string empEmail, string empSalary, string empStartDate)
        {
            String Error = "";

            //EmpName
            //***************
            if(empName.Length == 0)
            {
                Error = Error + "Error: the name may not be blank <br>";
            }

            if(empName.Length > 50 )
            {
                Error = Error + "Error: the name must be less than 50 characters <br>";
            }


            //EmpPosition
            //***************
            if (empPosition.Length == 0)
            {
                Error = Error + "Error: job position may not be blank <br>";
            }

            if (empPosition.Length > 50)
            {
                Error = Error + "Error: job position must be less than 50 characters  <br>";
            }

            //EmpEmail
            //***************

            if (empEmail.Length < 11)
            {
                Error = Error + "Error: email syntax is incorrect  <br>";

            }

            if (empEmail.Length > 50)
            {
                Error = Error + "Error: email must be less than 50 characters  <br>";
            }

            string emailEnd = "@gmail.com";
            string otherEnd = "@twentythree.com";

            if(!(empEmail.EndsWith(emailEnd) || empEmail.EndsWith(otherEnd)))
            {
                Error = Error + "Error: email must end with @gmail.com or @twentythree.com  <br>";
            }

            double salary;
            bool isItADouble = Double.TryParse(empSalary, out salary);

            if(!isItADouble)
            {
                Error = Error + "Error: salary is not correct (must be a double - e.g. 21000.0)  <br>";
            }

            if(salary<20000.0)
            {
                Error = Error + "Error: salary is too low.   <br>";
            }

            if (salary > 100000.0)
            {
                Error = Error + "Error: salary is too low.  <br>";
            }

            DateTime EmpStartDate;
            bool dateTimeCorrect = DateTime.TryParse(empStartDate, out EmpStartDate);

            if(!dateTimeCorrect)
            {
                Error = Error + "Error: date is incorrect, try format: DD/MM/YYYY   <br>";
            }

            DateTime companyStartDate = DateTime.Parse("01/02/2023");
            DateTime today = DateTime.Now.Date;

            if(EmpStartDate<companyStartDate)
            {
                Error = Error + "Error: date incorrect - must be before the start of the company  <br>";
            }

            if(EmpStartDate>today)
            {
                Error = Error + "Error: date incorrect. Date cannot be in the future  <br>";
            }

           


            return Error;
        }
    }
}
