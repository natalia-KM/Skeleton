using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
 
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
    }
}
