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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the validation
            Boolean found = false;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //test to see if the result is true, we do an assert on the boolean variable found
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestOrderLineNoFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the OrderLineNo
            if (AnOrderLine.OrderLineNo != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the OrderID
            if (AnOrderLine.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the ProductNo
            if (AnOrderLine.ProductNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the ProductDescription
            if (AnOrderLine.ProductDescription != "Nike Revival Ball")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the ItemQuantity
            if (AnOrderLine.ItemQuantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCostFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the results of the search
            Boolean found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Some test data created here to use with the Find method
            Int32 OrderLineNo = 2;
            //Method is then invoked
            found = AnOrderLine.Find(OrderLineNo);
            //check the TotalCost
            if (AnOrderLine.TotalCost != Convert.ToDouble(29.9800))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
