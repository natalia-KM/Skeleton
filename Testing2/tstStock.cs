using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //checks if clsStock exists
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Boolean to compare to the property
            Boolean TestData = true;
            //assigns the test data to the property
            stock.Active = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.Active, TestData);

        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type DataTime to compare to the property
            DateTime TestData = DateTime.Now.Date;
            //assigns the test data to the property
            stock.DateAdded = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.DateAdded, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type String to compare to the property
            string TestData = "XS - XXL";
            //assigns the test data to the property
            clsStock.Size = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(clsStock.Size, TestData);
        }

        [TestMethod]
        public void TypePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type String to compare to the property
            string TestData = "Basketball";
            //assigns the test data to the property
            clsStock.Type = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(clsStock.Type, TestData);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Integer to compare to the property
            Int32 TestData = 30;
            //assigns the test data to the property
            clsStock.Stock = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(clsStock.Stock, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Double to compare to the property
            double TestData = 80.0000;
            //assigns the test data to the property
            clsStock.Price = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(clsStock.Price, TestData);
        }
    }
}
