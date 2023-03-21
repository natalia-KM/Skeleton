using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            TestItem.Active = true;
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
            TestStock.Active = true;
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
            TestItem.Active = true;
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
    }
}
