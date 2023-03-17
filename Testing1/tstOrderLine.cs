using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderLine
    {

        //good test data for OrderLine 
        //create some test data to pass to the method
        string OrderID = "5";
        string ProductNo = "7";
        string ProductDescription = "Basketball";
        string ItemQuantity = "3";
        string TotalCost = "40.00";


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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // check if String var Error is equal to blank string "", blank string means no errors.
            // if the contents of the Error variable are not equal to "" blank string, this means an error or multiple errors have occurred
        }

        [TestMethod]
        public void OrderIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = "-1000000";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = "0";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = "1";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = "2";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = Int32.MaxValue.ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String OrderID = "2147483648"; // this value represents Int32.MaxValue + 1
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String OrderID = "joe";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDOtherTest()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String OrderID = "";  // check for what happens if the field is left blank.
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = "-2000000";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = "0";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = "1";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = "2";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = Int32.MaxValue.ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductNo = "2147483648"; // this value represents Int32.MaxValue + 1
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String ProductNo = "false";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoOtherTest()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String ProductNo = "";  // check for what happens if the field is left blank.
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = ""; // 0 characters
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, ""); // product description cannot be blank, it must be filled with atleast 1 character. So error should occur here.
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "a"; 
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // there shouldn't be any errors
        }

        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "aa"; // 2 characters
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(49, 'a'); // pads char 'a' 49 (max-1) times to current string contents of ProductDescription variable
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a'); // pads char 'a' 50 times to current string contents of ProductDescription variable
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(51, 'a'); // pads char 'a' 51 (max+1) times to current string contents of ProductDescription variable
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass, max char amount is 50, cannot have 51 chars.
            Assert.AreNotEqual(Error, ""); //there should be errors
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(300, 'a'); // pads char 'a' 300 times to current string contents of ProductDescription variable
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass, max char amount is 50, cannot have 300 chars.
            Assert.AreNotEqual(Error, ""); // there should be errors
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(25, 'a'); // pads char 'a' 25 times to current string contents of ProductDescription variable
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct, max amount of chars is 50 and 25 chars is acceptable because its below the max limit.
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void ProductDescriptionOtherTest() // test storing string containing characters from different languages.
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the ProductDescription var to a string containing characters of a different language (russian)
            String ProductDescription = "привет";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }



        [TestMethod]
        public void ItemQuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = "-4500000";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = "0";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = "1";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = "2";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = (Int32.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = Int32.MaxValue.ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ItemQuantity = "2147483648"; // this value represents Int32.MaxValue + 1
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String ItemQuantity = "3.42";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityOtherTest()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the variable to a value of incorrect data type
            String ItemQuantity = "";  // check for what happens if the field is left blank.
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TotalCostExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = "-2000000.00";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // an error should occur, string error should not be equal to "" because this would mean there aren't any errors. We need
            // the error variable to contain an error message to pass this test
        }

        [TestMethod]
        public void TotalCostMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = "-0.01";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // an error should occur, string error should not be equal to "" because this would mean there aren't any errors. We need
            // the error variable to contain an error message to pass this test
        }

        [TestMethod]
        public void TotalCostMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = "0.00";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = "0.01";
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = (Decimal.MaxValue - 1).ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = Decimal.MaxValue.ToString();
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String TotalCost = "79228162514264337593543950336"; // this value represents Decimal.MaxValue + 1
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the OrderCost to a non-double value
            String TotalCost = "" + 'e';
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostOtherTest()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //set the TotalCost to a non-double value
            String TotalCost = ""; // check what happens if field is left blank
            //invoke the method
            Error = AnOrderLine.Valid(OrderID, ProductNo, ProductDescription, ItemQuantity, TotalCost);
            //test to see that an error occurs so the test can pass
            Assert.AreNotEqual(Error, "");
        }
    }
}
