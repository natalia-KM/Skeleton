using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data for Order
        //create some test data to pass to the method
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderCost = "402.99";
        string CustomerID = "4";
        string Notes = "Please deliver next door";
        //string Dispatched = "true";
        string OrderQuantity = "3";


        [TestMethod]
        public void InstanceOK()
        {
            //Instantiate object of class type clsOrder
            clsOrder testOrder1 = new clsOrder();
            //Test to see that the instantiated object testOrder1 exists
            Assert.IsNotNull(testOrder1);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //Instantiate object of class type clsOrder
            clsOrder AnOrder = new clsOrder();
            // Creating a var TestData assigned to some data
            Int32 TestData = 1;
            // Assigning the data to the property OrderID of Order obj
            AnOrder.OrderID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type DateTime, test data will be assigned to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the test data to the property OrderDate
            AnOrder.OrderDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderCostPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type double(to represent money/currency)
            double TestData = 250.0;
            // Assign the test data to the property OrderCost
            AnOrder.OrderCost = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderCost, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type Int32
            Int32 TestData = 2;
            // Assign the test data to the property CustomerID
            AnOrder.CustomerID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void NotesPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type string
            string TestData = "Please deliver my order to my neighbours house to the left as I will not be home.";
            // Assign the test data to the property Notes
            AnOrder.Notes = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.Notes, TestData);
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type boolean
            Boolean TestData = true;
            // Assign the test data to the property Dispatched
            AnOrder.Dispatched = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }

        [TestMethod]
        public void OrderQuantityPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Creating TestData Var of type Int32
            Int32 TestData = 15;
            // Assign the test data to the property OrderQuantity
            AnOrder.OrderQuantity = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderQuantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean found = false;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3;
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //test to see if the result is true, we do an assert on the boolean variable found
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3;
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the OrderID
            if (AnOrder.OrderID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the OrderDate Property
            if (AnOrder.OrderDate != Convert.ToDateTime("10/02/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderCostFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the OrderCost Property
            if (AnOrder.OrderCost != Convert.ToDouble(29.9800))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the CustomerID Property
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNotesFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the Notes Property
            if (AnOrder.Notes != "")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the Dispatched Property
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderID = 3; // this refers to record with primary key OrderID 3
            //Method is then invoked
            found = AnOrder.Find(OrderID);
            //check the OrderQuantity Property
            if (AnOrder.OrderQuantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // check if String var Error is equal to blank string "", blank string means no errors.
            // if the contents of the Error variable are not equal to "" blank string, this means an error or multiple errors have occurred

        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, 100 years ago
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day (-1, go one day back)
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to Todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day (+1, go one day forward)
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, 100 years from now
            TestDate = TestDate.AddYears(100);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non-date values
            string OrderDate = "joe";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // error should occur
        }

        [TestMethod]
        public void OrderDateOtherTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non-date values
            string OrderDate = ""; // check what happens if field is left blank
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // error should occur
        }

        [TestMethod]
        public void OrderCostExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = "-1000000.00";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // an error should occur, string error should not be equal to "" because this would mean there aren't any errors. We need
            // the error variable to contain an error message to pass this test
        }

        [TestMethod]
        public void OrderCostMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = "-0.01";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // an error should occur, string error should not be equal to "" because this would mean there aren't any errors. We need
            // the error variable to contain an error message to pass this test
        }

        [TestMethod]
        public void OrderCostMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = "0.00";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = "0.01";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void OrderCostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = (Decimal.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCostMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = Decimal.MaxValue.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderCost = "79228162514264337593543950336"; // this value represents Decimal.MaxValue + 1
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderCostInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderCost to a non-double value
            String OrderCost = "true";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderCostOtherTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderCost to a non-double value
            String OrderCost = ""; // check what happens if field is left blank
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = "-1000000";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = "0";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = "1";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = "2";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = Int32.MaxValue.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String CustomerID = "2147483648"; // this value represents Int32.MaxValue + 1
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String CustomerID = "" + 'b';
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDOtherTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String CustomerID = "";  // check for what happens if the field is left blank.
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NotesMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = ""; // 0 characters
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors, inputting 0 chars is acceptable as this would mean
            // you are leaving the Notes field blank.
        }

        [TestMethod]
        public void NotesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "a"; // 1 character
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors, inputting 0 chars is acceptable as this would mean
            // you are leaving the Notes field blank.
        }

        [TestMethod]
        public void NotesMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "";
            Notes = Notes.PadRight(79, 'a'); // pads char 'a' 79 (max-1) times to current string contents of Notes variable
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors, inputting 0 chars is acceptable as this would mean
            // you are leaving the Notes field blank.
        }

        [TestMethod]
        public void NotesMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "";
            Notes = Notes.PadRight(80, 'a'); // pads char 'a' 80 times to current string contents of Notes variable
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors, inputting 0 chars is acceptable as this would mean
            // you are leaving the Notes field blank.
        }

        [TestMethod]
        public void NotesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "";
            Notes = Notes.PadRight(81, 'a'); // pads char 'a' 81 (max+1) times to current string contents of Notes variable
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); //there should be errors
        }

        [TestMethod]
        public void NotesExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "";
            Notes = Notes.PadRight(200, 'a'); // pads char 'a' 200 times to current string contents of Notes variable
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void NotesMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String Notes = "";
            Notes = Notes.PadRight(40, 'a'); // pads char 'a' 40 times to current string contents of Notes variable
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors, inputting 0 chars is acceptable as this would mean
            // you are leaving the Notes field blank.
        }

        [TestMethod]
        public void NotesOtherTest() // Trying strings which contain letters from different languages
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the Notes var to a string containing characters of a different language (russian)
            String Notes = "ИЙКЛ";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void OrderQuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = "-1000000";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void OrderQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = "0";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void OrderQuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = "1";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = "2";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderQuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = Int32.MaxValue.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderQuantity = "2147483648"; // this value represents Int32.MaxValue + 1
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void OrderQuantityInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String OrderQuantity = "2.5";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void OrderQuantityOtherTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String OrderQuantity = "";  // check for what happens if the field is left blank.
            //invoke the method
            Error = AnOrder.Valid(OrderDate, OrderCost, CustomerID, Notes, OrderQuantity);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // there should be errors
        }
    }
}
