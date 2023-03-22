using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        // creates some test data to pass to the method
        string FullName = "Natalia Kmiecik";
        string Email = "natty@gmail.com";
        string PhoneNumber = "+44 7355889911";
        string DateOfBirth = "05/12/1997";
        string TotalSpent = "30.0000";
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.FullName != "Stefan Calarasu")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Email != "stefcsu@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.PhoneNumber != "07388596274")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("23/12/1987"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalSpentFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.TotalSpent != 29.9800) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDataAddedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.PaymentDataAdded != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "a";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "aa";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            FullName = FullName.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            FullName = FullName.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            FullName = FullName.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            FullName = FullName.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String FullName = "";
            FullName = FullName.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "@";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "@@";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            Email = Email.PadRight(49, '@');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            Email = Email.PadRight(50, '@');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "";
            Email = Email.PadRight(25, '@');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailOtherTests()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Email = "stefcal@gmail.com";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "+1234";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "+12345";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(14, '+');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(15, '+');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(16, '+');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(30, '+');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(8, '+');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberOtherTests()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String PhoneNumber = "+40724171714";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, 300 years ago
            TestDate = TestDate.AddYears(-300);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-124);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to Todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-123);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-122);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, 300 years from now
            TestDate = TestDate.AddYears(300);
            //Convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non-date values
            string DateOfBirth = "abc";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // error should occur
        }

        /*
        [TestMethod]
        public void DateOfBirthOtherTest()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non-date values
            string DateOfBirth = "01/01/2010";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // error should occur
        }
        */

        [TestMethod]
        public void TotalSpentExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = "-1000000.00";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void TotalSpentMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = "-0.01";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void TotalSpentMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = "0.00";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalSpentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = "0.01";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalSpentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = (Decimal.MaxValue - 1).ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalSpentMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = Decimal.MaxValue.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalSpentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalSpent = "79228162514264337593543950336"; // this value represents Decimal.MaxValue + 1
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalSpentInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the TotalSpent to a non-double value
            String TotalSpent = "abcd";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, PhoneNumber, DateOfBirth, TotalSpent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

