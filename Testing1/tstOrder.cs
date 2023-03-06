using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
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
            Int32 OrderID = 2;
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
    }
}
