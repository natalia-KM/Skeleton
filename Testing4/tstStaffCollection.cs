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


        [TestMethod]
        public void UpdateMethodOK()
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

            staff.BonusEligible = false;
            staff.EmployeeID = 3;
            staff.EmployeeName = "Sots";
            staff.EmployeePosition = "Menager";
            staff.EmployeeEmail = "sotos@twentythree.com";
            staff.EmployeeSalary = 24000.0;
            staff.EmployeeStartDate = DateTime.Parse("25/02/2023");

            allStaff.ThisEmployee = staff;
            allStaff.Update();
            allStaff.ThisEmployee.Find(PrimaryKey);

            Assert.AreEqual(allStaff.ThisEmployee, staff);

        }

        [TestMethod]
        public void DeleteMethodOK()
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

            allStaff.Delete();

            Boolean Found = allStaff.ThisEmployee.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaffCollection filteredStaff = new clsStaffCollection();
            filteredStaff.ReportByName("");
            Assert.AreEqual(allStaff.Count, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();
            filteredStaff.ReportByName("yyy yy");
            Assert.AreEqual(0, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();
            Boolean OK = true;
            filteredStaff.ReportByName("xxx xx");

            if(filteredStaff.Count==2)
            {
                if(filteredStaff.StaffList[0].EmployeeID!=45)
                {
                    OK = false;
                }
                if (filteredStaff.StaffList[1].EmployeeID != 170)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
