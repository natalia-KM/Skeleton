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
    }
}
