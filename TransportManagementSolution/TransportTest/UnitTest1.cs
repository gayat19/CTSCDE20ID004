using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TranportManagementBLLibrary;

namespace TransportTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("Sample Test")]
        public void TestMethod1()
        {
            EmployeeBL bl = new EmployeeBL();
            int result = bl.TestCheck(100);
            Assert.AreEqual(101, result);
        }
        [TestMethod]
        public void CheckWithNegativeForTestCheckMethod()
        {
            EmployeeBL bl = new EmployeeBL();
            int result = bl.TestCheck(-20);
            Assert.AreEqual(-19, result);
        }
        [TestMethod("Test List")]
        public void TestMethod2()
        {
            EmployeeBL bl = new EmployeeBL();
            int result = bl.GetData().Count;
            Assert.AreEqual(3, result);
        }
    }
}
