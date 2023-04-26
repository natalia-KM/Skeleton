using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.PaymentDataAdded = true;
            TestItem.CustomerID = 20;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.FullName = " customer full name ";
            TestItem.Email = " customer email ";
            TestItem.PhoneNumber = " customer phone ";
            TestItem.TotalSpent = 1000000;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }
        
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.PaymentDataAdded = true;
            TestCustomer.CustomerID = 20;
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.FullName = " customer full name ";
            TestCustomer.Email = " customer email ";
            TestCustomer.PhoneNumber = " customer phone ";
            TestCustomer.TotalSpent = 1000000;
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.PaymentDataAdded = true;
            TestItem.CustomerID = 20;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.FullName = " customer full name ";
            TestItem.Email = " customer email ";
            TestItem.PhoneNumber = " customer phone ";
            TestItem.TotalSpent = 1000000;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.PaymentDataAdded = true;
            TestItem.CustomerID = 5;
            TestItem.FullName = "Joe Bloggs";

            TestItem.Email = "joebloggs@gmail.com";

            TestItem.PhoneNumber = "07413851353";

            TestItem.DateOfBirth = Convert.ToDateTime("05/02/94");

            TestItem.TotalSpent = 60.99;

            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.PaymentDataAdded = false;
            TestItem.FullName = "John Doe";
            TestItem.Email = "jdoe2004@outlook.com";
            TestItem.PhoneNumber = "07312053524";
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/1985");
            TestItem.TotalSpent = 105.00;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            //modify test data for updating
            TestItem.PaymentDataAdded = true;
            TestItem.FullName = "John Doe";
            TestItem.Email = "jdoe2004@outlook.com";
            TestItem.PhoneNumber = "07312053524";
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/1984");
            TestItem.TotalSpent = 120.00;
            AllCustomer.ThisCustomer = TestItem;
            //update record
            AllCustomer.Update();
            //find record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.PaymentDataAdded = true;
            TestItem.FullName = "Fred Nerk";
            TestItem.Email = "frednerk09@gmail.com";
            TestItem.PhoneNumber = "07553523952";
            TestItem.DateOfBirth = Convert.ToDateTime("23/06/1996");
            TestItem.TotalSpent = 59.99;
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a full name filter that doesn't exist
            FilteredCustomers.ReportByFullName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name filter that doesn't exist
            FilteredCustomers.ReportByFullName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is CustomerID 16
                if (FilteredCustomers.CustomerList[0].CustomerID != 16)
                {
                    OK = false;
                }
                //check that the second record is CustomerID 17
                if (FilteredCustomers.CustomerList[1].CustomerID != 17)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are records
            Assert.IsTrue(OK);
        }
    }
}
