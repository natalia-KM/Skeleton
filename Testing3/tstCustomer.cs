using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer testCustomer = new clsCustomer();
            Assert.IsNotNull(testCustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            Int32 TestData = 1;
            // assign the data to the property
            ACustomer.CustomerID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            string TestData = "Stefan Calarasu";
            // assign the data to the property
            ACustomer.FullName = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.FullName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            String TestData = "pasariss_l@yahoo.com";
            // assign the data to the property
            ACustomer.Email = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            string TestData = "07388596274";
            // assign the data to the property
            ACustomer.PhoneNumber = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            ACustomer.DateOfBirth = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void TotalSpentPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            double TestData = 100.52;
            // assign the data to the property
            ACustomer.TotalSpent = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.TotalSpent, TestData);
        }

        [TestMethod]
        public void PaymentDataAddedPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data
            Boolean TestData = true;
            // assign the data to the property
            ACustomer.PaymentDataAdded = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.PaymentDataAdded, TestData);
        }
    }
}

