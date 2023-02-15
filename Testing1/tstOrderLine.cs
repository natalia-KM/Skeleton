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
    }
}
