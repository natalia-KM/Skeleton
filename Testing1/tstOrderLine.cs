using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Instantiate object of class type clsOrderLine
            clsOrderLine testOrderLine1 = new clsOrderLine();
            //Test to see that the instantiated object testOrderLine1 exists
            Assert.IsNotNull(testOrderLine1);
        }

        [TestMethod]
        public void OrderLineNoPropertyOK()
        {
            //Instantiate object of class type clsOrderLine
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating a var TestData assigned to some data
            Int32 TestData = 2;
            // Assigning the data to the property OrderLineNo of OrderLine obj
            AnOrderLine.OrderLineNo = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineNo, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating TestData Var of type Int32
            Int32 TestData = 3;
            // Assign the test data to the property OrderID
            AnOrderLine.OrderID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating TestData Var of type Int32
            Int32 TestData = 1;
            // Assign the test data to the property ProductNo
            AnOrderLine.ProductNo = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductNo, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating TestData Var of type string
            string TestData = "This basketball is high quality and is made with good materials.";
            // Assign the test data to the property ProductDescription
            AnOrderLine.ProductDescription = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductDescription, TestData);
        }

        [TestMethod]
        public void ItemQuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating TestData Var of type Int32
            Int32 TestData = 4;
            // Assign the test data to the property ItemQuantity
            AnOrderLine.ItemQuantity = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ItemQuantity, TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            // Creating TestData Var of type double
            double TestData = 29.98;
            // Assign the test data to the property TotalCost
            AnOrderLine.TotalCost = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.TotalCost, TestData);
        }
    }
}
