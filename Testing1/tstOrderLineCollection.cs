using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            //create the item of test data which is an OrderLine object
            // orderline objects can be stored in the TestList which 
            // accepts OrderLine objects only.. to be stored in the list
            clsOrderLine TestItem = new clsOrderLine();
            //TestItem is a test OrderLine object
            //set the TestItem's properties
            TestItem.OrderLineNo = 10;
            TestItem.OrderID = 10;
            TestItem.ProductNo = 2;
            TestItem.ProductDescription = "Philadelphia 76ers Icon Edition";
            TestItem.ItemQuantity = 1;
            TestItem.TotalCost = 80.0000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }

        /* REDUNDANT TEST
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrderLines.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, SomeCount);
        }
        */
        

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            clsOrderLine TestOrderLine = new clsOrderLine();
            //set the properties of the test OrderLine object
            TestOrderLine.OrderLineNo = 11;
            TestOrderLine.OrderID = 10;
            TestOrderLine.ProductNo = 3;
            TestOrderLine.ProductDescription = "Team 31 2023 Paris";
            TestOrderLine.ItemQuantity = 1;
            TestOrderLine.TotalCost = 30.0000;
            //assign the data to the property
            AllOrderLines.ThisOrderLine = TestOrderLine;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //TestItem is a test OrderLine object instance
            //set the properties of the TestItem
            TestItem.OrderLineNo = 12;
            TestItem.OrderID = 11;
            TestItem.ProductNo = 1;
            TestItem.ProductDescription = "Nike Revival Ball";
            TestItem.ItemQuantity = 3;
            TestItem.TotalCost = 44.9700;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }
        
        /* REDUNDANT TEST
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, 2);
        }
        */
    }
}
