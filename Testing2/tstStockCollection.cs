﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //tests to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //creates test data
            List<clsStock> TestList = new List<clsStock>();
            //adds an item to the list
            clsStock TestItem = new clsStock();
            //sets the properties
            TestItem.ProductNo = 3;
            TestItem.ProductDescription = "Adidas Shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "7";
            TestItem.Type = "Shoes";
            TestItem.Stock = 50;
            TestItem.Price = 5.5;
            //adds the attributes to TestList
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //checks if the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //creates test data to assign to the property
            clsStock TestStock = new clsStock();
            //sets the properties
            TestStock.ProductNo = 3;
            TestStock.ProductDescription = "Adidas Shoes";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Size = "7";
            TestStock.Type = "Shoes";
            TestStock.Stock = 50;
            TestStock.Price = 5.5;
            //adds the attributes to TestStock
            AllStock.ThisStock = TestStock;
            //tests if the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //creates test data
            List<clsStock> TestList = new List<clsStock>();
            //adds an item to the list
            clsStock TestItem = new clsStock();
            //sets the properties
            TestItem.ProductNo = 3;
            TestItem.ProductDescription = "Adidas Shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "7";
            TestItem.Type = "Shoes";
            TestItem.Stock = 50;
            TestItem.Price = 5.5;
            //adds the attributes to TestList
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //tests to see if the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //creates a variable TestItem to store test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //sets the properties for TestItem
            TestItem.ProductNo = 3;
            TestItem.ProductDescription = "Adidas Shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "7";
            TestItem.Type = "Shoes";
            TestItem.Stock = 50;
            TestItem.Price = 5.5;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //tests to see if the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //creates a variable TestItem to store test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //sets the properties for TestItem
            TestItem.ProductDescription = "Adidas Shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "7";
            TestItem.Type = "Shoes";
            TestItem.Stock = 50;
            TestItem.Price = 5.5;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //modifing the test data
            TestItem.ProductDescription = "some other shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "4";
            TestItem.Type = "Shoes";
            TestItem.Stock = 20;
            TestItem.Price = 120.0;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
    
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //creates a variable TestItem to store test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //sets the properties for TestItem
            TestItem.ProductDescription = "Adidas Shoes";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Size = "7";
            TestItem.Type = "Shoes";
            TestItem.Stock = 50;
            TestItem.Price = 5.5;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //deletes the record
            AllStock.Delete();
            //finds the record and returns true or false
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see if the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTypeOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string, this will return all the records
            FilteredStock.ReportByType("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByTypeNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string, this will return all the records
            FilteredStock.ReportByType("skateboard");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByTypeTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //boolean to store the outcome
            Boolean OK = true;
            //apply a blank string, this will return all the records
            FilteredStock.ReportByType("Jersey");
            //check that the correct number of records are found
            if (FilteredStock.Count == 3)
            {
                //checks that the first record is ID 6
                if (FilteredStock.StockList[0].ProductNo != 6)
                {
                    OK = false;
                }
                //checks that the second record is ID 8
                if (FilteredStock.StockList[1].ProductNo != 8)
                {
                    OK = false;
                }
                //checks that the third record is ID 13
                if (FilteredStock.StockList[2].ProductNo != 13)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
