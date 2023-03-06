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
        public void ProductNoPropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Int32 to compare to the property
            Int32 TestData = 1;
            //assigns the test data to the property
            stock.ProductNo = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.ProductNo, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type string to compare to the property
            string TestData = "Nike Revival Ball";
            //assigns the test data to the property
            stock.ProductDescription = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.ProductDescription, TestData);
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
            stock.Size = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.Size, TestData);
        }

        [TestMethod]
        public void TypePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type String to compare to the property
            string TestData = "Basketball";
            //assigns the test data to the property
            stock.Type = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.Type, TestData);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Integer to compare to the property
            Int32 TestData = 30;
            //assigns the test data to the property
            stock.Stock = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.Stock, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //creates test data of type Double to compare to the property
            double TestData = 80.0000;
            //assigns the test data to the property
            stock.Price = TestData;
            //checks if the test data and the property are the same
            Assert.AreEqual(stock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //assigns a variable with test data to use for the method 
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //checks if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the ProductNo is not equal to 3 then it sets OK to false
            if(stock.ProductNo != 3)
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the product description does not match then OK will be set to false
            if (stock.ProductDescription != "Nike Revival Ball")
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDataAddedFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the DateAdded does not match then OK will be set to false
            if (stock.DateAdded != Convert.ToDateTime("09/02/2023"))
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the Size does not match then OK will be set to false
            if (stock.Size != "7")
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTypeFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the type does not match then OK will be set to false
            if (stock.Type != "Basketball")
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the Stock does not match then OK will be set to false
            if (stock.Stock != 50)
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //creates an instance of the class in the variable stock
            clsStock stock = new clsStock();
            //boolean variable with the default value 'false', will be used for validation
            Boolean Found = false;
            //boolean variable to make sure the data is ok
            Boolean OK = true;
            //assigns a variable with test data to use for the method
            Int32 ProductNo = 3;
            //invokes the method
            Found = stock.Find(ProductNo);
            //if the Price does not match then OK will be set to false
            if (stock.Price != 14.99)
            {
                OK = false;
            }
            //checks if the result is true
            Assert.IsTrue(OK);
        }
    }
}
