using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff staff = new clsStaff();

            staff.BonusEligible = true;
            staff.EmployeeID = 1;
            staff.EmployeeName = "Soto";
            staff.EmployeePosition = "Manager";
            staff.EmployeeEmail = "soto@twentythree.com";
            staff.EmployeeSalary = 23000.0;
            staff.EmployeeStartDate = DateTime.Parse("23/02/2023");

            TestList.Add(staff);

            allStaff.StaffList = TestList;

            Assert.AreEqual(allStaff.StaffList, TestList);
        }

     

        [TestMethod]
        public void ThisEmployeePropertyOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff staff = new clsStaff();

            staff.BonusEligible = true;
            staff.EmployeeID = 1;
            staff.EmployeeName = "Soto";
            staff.EmployeePosition = "Manager";
            staff.EmployeeEmail = "soto@twentythree.com";
            staff.EmployeeSalary = 23000.0;
            staff.EmployeeStartDate = DateTime.Parse("23/02/2023");


            allStaff.ThisEmployee = staff;

            Assert.AreEqual(allStaff.ThisEmployee, staff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff staff = new clsStaff();

            staff.BonusEligible = true;
            staff.EmployeeID = 1;
            staff.EmployeeName = "Soto";
            staff.EmployeePosition = "Manager";
            staff.EmployeeEmail = "soto@twentythree.com";
            staff.EmployeeSalary = 23000.0;
            staff.EmployeeStartDate = DateTime.Parse("23/02/2023");

            TestList.Add(staff);

            allStaff.StaffList = TestList;

            Assert.AreEqual(allStaff.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff staff = new clsStaff();
            Int32 PrimaryKey = 0;

            staff.BonusEligible = true;
            staff.EmployeeID = 1;
            staff.EmployeeName = "Soto";
            staff.EmployeePosition = "Manager";
            staff.EmployeeEmail = "soto@twentythree.com";
            staff.EmployeeSalary = 23000.0;
            staff.EmployeeStartDate = DateTime.Parse("23/02/2023");

            allStaff.ThisEmployee = staff;
            PrimaryKey = allStaff.Add();
            staff.EmployeeID = PrimaryKey;
            allStaff.ThisEmployee.Find(PrimaryKey);

            Assert.AreEqual(allStaff.ThisEmployee, staff);

        }
    }
}
