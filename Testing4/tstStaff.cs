using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
         
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }

    }
}
