using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Instantiate object of class type clsOrder
            clsOrder testOrder1 = new clsOrder();
            //Test to see that the instantiated object testOrder1 exists
            Assert.IsNotNull(testOrder1);

        }
    }
}
