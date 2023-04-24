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
        

    }
}
