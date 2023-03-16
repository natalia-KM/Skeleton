using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        //test data for the method
        string ProductDescription = "Adidas Shoes";
        string DateAdded = DateTime.Now.Date.ToString();
        string Size = "7";
        string Type = "Shoes";
        string Stock = "50";
        string Price = "1.50";


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
        
        [TestMethod]
        public void ValidMethodOK()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionNoMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "a";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "aa";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(49, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionNoMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionNoMid()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(25, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(51, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(500, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates a variable to store test date data
            DateTime TestDate;
            //variable TestDate set to today's date
            TestDate = DateTime.Now.Date;
            //changes the date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            //converts the date into string
            string DateAdded = TestDate.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates a variable to store test date data
            DateTime TestDate;
            //variable TestDate set to today's date
            TestDate = DateTime.Now.Date;
            //changes the date to yesterday
            TestDate = TestDate.AddDays(-1);
            //converts the date into string
            string DateAdded = TestDate.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates a variable to store test date data
            DateTime TestDate;
            //variable TestDate set to today's date
            TestDate = DateTime.Now.Date;
            //converts the date into string
            string DateAdded = TestDate.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates a variable to store test date data
            DateTime TestDate;
            //variable TestDate set to today's date
            TestDate = DateTime.Now.Date;
            //changes the date to yesterday
            TestDate = TestDate.AddDays(1);
            //converts the date into string
            string DateAdded = TestDate.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates a variable to store test date data
            DateTime TestDate;
            //variable TestDate set to today's date
            TestDate = DateTime.Now.Date;
            //changes the date to yesterday
            TestDate = TestDate.AddDays(100);
            //converts the date into string
            string DateAdded = TestDate.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //set DateAdded into a non date value
            string DateAdded = "Wrong Data Type";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "a";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "aa";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "";
            Size = Size.PadRight(9, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "";
            Size = Size.PadRight(10, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "";
            Size = Size.PadRight(11, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMid()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data for the valid method
            string Size = "";
            Size = Size.PadRight(5, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeExtremeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Size = "";
            Size = Size.PadRight(100, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "a";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "aa";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            Type = Type.PadRight(9, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            Type = Type.PadRight(10, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            Type = Type.PadRight(11, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMid()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            Type = Type.PadRight(5, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeExtremeMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Type = "";
            Type = Type.PadRight(100, 'a');
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockMaxLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockMid()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Int32 TestStock = Int32.MaxValue / 2;
            string Stock = TestStock.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockInvalidData()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Stock = "this is invalid data";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Double TestPrice = 0;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Double TestPrice = 0.01;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Double TestPrice = 0.02;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method, Double.MaxValue outputs an overflow error therefore I changed it into In32.MaxValue
            Double TestPrice = Int32.MaxValue - 1;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method, Double.MaxValue outputs an overflow error therefore I changed it into In32.MaxValue
            Double TestPrice = Int32.MaxValue;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            Double TestPrice = Int32.MaxValue / 2;
            string Price = TestPrice.ToString();
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //creates an instance of the class in the variable AStock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //creates test data to pass the method
            string Price = "This is a invalid data type";
            //invokes the method
            Error = AStock.Valid(ProductDescription, DateAdded, Size, Type, Stock, Price);
            //checks if the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }

}
