using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data which is an Order object
            // order objects can be stored in the TestList which 
            // accepts Order objects only.. to be stored in the list
            clsOrder TestItem = new clsOrder();
            //TestItem is a test Order object
            //set the TestItem's properties
            TestItem.Dispatched = true;
            TestItem.OrderID = 18;
            TestItem.OrderDate = Convert.ToDateTime("22/03/2023");
            TestItem.OrderCost = 60.0000;
            TestItem.CustomerID = 7;
            TestItem.Notes = "Test note hello order";
            TestItem.OrderQuantity = 4;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        /* REDUNDANT TEST
         * 
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
        */

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test Order object
            TestOrder.Dispatched = true;
            TestOrder.OrderID = 19;
            TestOrder.OrderDate = Convert.ToDateTime("22/03/2023");
            TestOrder.OrderCost = 79.9900;
            TestOrder.CustomerID = 8;
            TestOrder.Notes = "";
            TestOrder.OrderQuantity = 2;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //TestItem is a test Order object instance
            //set the properties of the TestItem
            TestItem.Dispatched = false;
            TestItem.OrderID = 19;
            TestItem.OrderDate = Convert.ToDateTime("22/03/2023");
            TestItem.OrderCost = 89.9400;
            TestItem.CustomerID = 8;
            TestItem.Notes = "Deliver and place the item on the front door mat.";
            TestItem.OrderQuantity = 3;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        /* REDUNDANT TEST
         * 
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }
        */
    }
}