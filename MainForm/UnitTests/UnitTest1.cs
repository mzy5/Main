using System;
using MainForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ValidateMin validatorObject = new ValidateMin();
            var min = validatorObject.GetMin(10, 9, 9);

            Assert.AreEqual(9, min);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ValidateMin validatorObject = new ValidateMin();
            var min = validatorObject.GetMin(9, 9, 9);

            Assert.AreEqual(9, min);
        }
    }
}
