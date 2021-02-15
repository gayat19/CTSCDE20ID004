using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TranportManagementBLLibrary;

namespace NUnitTransportTest
{
    [TestFixture]
    public class Class1
    {
        protected EmployeeBL _bl;
        private bool _check;

        [SetUp]
        public void Init()
        {
            _check = true;
            _bl = new EmployeeBL();
        }
        //[TearDown]
        //public void CleanUp()
        //{
        //    _bl = null;
        //}
        [Test]
        public void MyCheck()
        {
            Assert.IsTrue(_check);
        }

        [Test]
        [TestCase(100,ExpectedResult =101),Order(2)]
        [TestCase(101, ExpectedResult = 102)]
        [TestCase(103, ExpectedResult = 104)]
        public int TestCheck(int num)
        {
            int res = _bl.TestCheck(num);
            return res;
        }
    }
    //[TestFixture]
    //public class ChildTest : Class1
    //{
    //    [TestCase(10,ExpectedResult =11)]
    //    public int TestCheckChild(int num)
    //    {
    //        int res = _bl.TestCheck(num);
    //        return res;
    //    }
    //    [TestCase(10, ExpectedResult = 11)]
    //    public int TestCheckChild2(int num)
    //    {
    //        int res = _bl.TestCheck(num);
    //        return res;
    //    }
    //}
}
