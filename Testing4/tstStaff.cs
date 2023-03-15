using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {

        string empName = "Kim";
        string empPosition = "Manager";
        string empEmail = "kim@gmail.com";
        string empSalary = "21000.0";
        string empStartDate = "21/02/2023";

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void EmployeeIDPropertyOK()
        {
            clsStaff staff = new clsStaff();
            Int32 TestData = 1;
            staff.EmployeeID = TestData;
            Assert.AreEqual(staff.EmployeeID, TestData);
        }

        [TestMethod]
        public void EmployeeNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Natalia";
            staff.EmployeeName = TestData;
            Assert.AreEqual(staff.EmployeeName, TestData);
        }

        [TestMethod]
        public void EmployeePositionPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Manager";
            staff.EmployeePosition = TestData;
            Assert.AreEqual(staff.EmployeePosition, TestData);
        }

        [TestMethod]
        public void EmployeeEmailPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "emp@ac.uk";
            staff.EmployeeEmail = TestData;
            Assert.AreEqual(staff.EmployeeEmail, TestData);
        }

        [TestMethod]
        public void EmployeeStartDatePropertyOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.EmployeeStartDate = TestData;
            Assert.AreEqual(staff.EmployeeStartDate, TestData);
        }

        [TestMethod]
        public void EmployeeSalaryPropertyOK()
        {
            clsStaff staff = new clsStaff();
            double TestData = 2110.0;
            staff.EmployeeSalary = TestData;
            Assert.AreEqual(staff.EmployeeSalary, TestData);
        }

        [TestMethod]
        public void BonusEligiblePropertyOK()
        {
            clsStaff staff = new clsStaff();
            Boolean TestData = true;
            staff.BonusEligible = TestData;
            Assert.AreEqual(staff.BonusEligible, TestData);
        }

        [TestMethod]
        public void TestEmpIDFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeeID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmpNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeeName != "Natalia")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmpPositionFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeePosition != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmpEmailFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeeEmail != "nat@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmpStartDateFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeeStartDate != Convert.ToDateTime("05/02/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmpSalaryFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.EmployeeSalary != 23000.0)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBonusEligibleFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);

            if (staff.BonusEligible != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }





        [TestMethod]
        public void FindMethodOK() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Int32 EmpID = 1;
            found = staff.Find(EmpID);
            Assert.IsTrue(found);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }


        // *******************
        //EmployeeName Tests
        // *******************

        public void EmpNameMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "a";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "aa";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVW";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmpNameMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMid()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpName = "";
            EmpName = EmpName.PadRight(100);
            Error = staff.Valid(EmpName, empPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // *******************
        //EmployeePosition Tests
        // *******************

        public void EmpPositionMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "a";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "aa";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVW";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmpPositionMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionMid()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpPositionExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpPosition = "";
            EmpPosition = EmpPosition.PadRight(100, 'A');
            Error = staff.Valid(empName, EmpPosition, empEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        // *******************
        //EmployeeEmail Tests
        // *******************

        public void EmpEmailMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "@gmail.com";
            EmpEmail = 
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "a@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "aa@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCEFGHIJKLMN@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmpEmailMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ABCCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMN@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailMid()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ZABCDEFGHIJKLMN@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpEmailExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNAAAAAAAAAA@gmail.com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        public void EmpEmailIsSyntaxCorrect()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpEmail = "ala@com";
            Error = staff.Valid(empName, empPosition, EmpEmail, empSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }




        // *******************
        //EmployeeSalary Tests
        // *******************

        public void EmpSalaryExtremeMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "-1000.0";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        public void EmpSalaryMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "19999.0";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "20000.0";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "20000.01";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "99999.9";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmpSalaryMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "100000.0";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "100000.01";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryMid()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "60000.0";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpSalaryExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "1000000000.01";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }

        public void EmpSalaryIsADouble()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpSalary = "asda.a";
            Error = staff.Valid(empName, empPosition, empEmail, EmpSalary, empStartDate);
            Assert.AreNotEqual(Error, "");
        }




        // *******************
        //EmployeeStartDate Tests
        // *******************

        public void EmpStartDateExtremeMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            //1st February 2023 - the start date of the 'company'
            DateTime TestDate = DateTime.Parse("01/02/2023");
            TestDate = TestDate.AddYears(-20);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateMinLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            //1st February 2023 - the start date of the 'company'
            DateTime TestDate = DateTime.Parse("01/02/2023");
            TestDate = TestDate.AddDays(-1);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateMin()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            //1st February 2023 - the start date of the 'company'
            string EmpStartDate = "01/02/2023";
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            //1st February 2023 - the start date of the 'company'
            DateTime TestDate = DateTime.Parse("01/02/2023");
            TestDate = TestDate.AddDays(1);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmpStartDateMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpStartDateExtremeMax()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20);
            string EmpStartDate = TestDate.ToString();
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmpStartDateIsSyntaxCorrect()
        {
            clsStaff staff = new clsStaff();
            String Error = "";
            string EmpStartDate = "aaa/2/a";
            Error = staff.Valid(empName, empPosition, empEmail, empSalary, EmpStartDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
