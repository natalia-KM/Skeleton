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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderID = 20;
            TestItem.OrderDate = Convert.ToDateTime("26/03/2023");
            TestItem.OrderCost = 30.0000;
            TestItem.CustomerID = 9;
            TestItem.Notes = "Deliver asap please.";
            TestItem.OrderQuantity = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderID = 21;
            TestItem.OrderDate = Convert.ToDateTime("24/04/2023");
            TestItem.OrderCost = 60.0000;
            TestItem.CustomerID = 10;
            TestItem.Notes = "";
            TestItem.OrderQuantity = 2;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.Dispatched = false;
            TestItem.OrderID = 21;
            TestItem.OrderDate = Convert.ToDateTime("24/04/2023");
            TestItem.OrderCost = 90.0000;
            TestItem.CustomerID = 10;
            TestItem.Notes = "";
            TestItem.OrderQuantity = 3;
            //set the record baed on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            //ThisOrder contained a record, which then had its data updated via updating the data of the test data 
            // and assigning this test data to the ThisOrder property of the collections class
            //Update method was performed and now checking if that record can be found
            // in the data layer, then compare that found record to the test data (which was updated)
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderID = 21;
            TestItem.OrderDate = Convert.ToDateTime("24/04/2023");
            TestItem.OrderCost = 90;
            TestItem.CustomerID = 10;
            TestItem.Notes = "";
            TestItem.OrderQuantity = 3;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerIDMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a filter of 1 so all records with CustomerID 1 will be visible.
            FilteredOrders.ReportByCustomerID(1);
            //test to see that the two values are the same
            Assert.AreEqual(1, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a customerID filter that doesn't exist.
            FilteredOrders.ReportByCustomerID(-1);
            //test to see that there are no records, because since the filter has been
            // applied, there should be no records because the CustomerID value provided as filter doesn't exist
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a CustomerID filter
            FilteredOrders.ReportByCustomerID(999);
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 47
                if (FilteredOrders.OrderList[0].OrderID != 47)
                {
                    OK = false; // if the retrieved record's OrderID is not equal to xx then set OK to false
                    //..because the record that was retrieved is not the record created specifically for this test
                }
                //check that the second record is ID 48
                if (FilteredOrders.OrderList[1].OrderID != 48)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the created records in the data layer for 
            // the purpose of this test, were found.
            Assert.IsTrue(OK);
        }

    }
}