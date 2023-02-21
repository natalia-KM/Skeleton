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
    }
}
