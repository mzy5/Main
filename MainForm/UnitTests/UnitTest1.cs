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
            Validate validatorObject = new Validate();
            var min = validatorObject.GetMin(9, 9, 9);

            Assert.AreEqual(9, min);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Validate validatorObject = new Validate();
            var min = validatorObject.GetMin(1,2,3);

            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Validate validatorObject = new Validate();
            var min = validatorObject.GetMin(1,3,2);

            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Validate validatorObject = new Validate();
            var min = validatorObject.GetMin(3,2,1);

            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Validate validatorObject = new Validate();
            var min = validatorObject.GetMin(0, 0, 0);

            Assert.AreEqual(0, min);
        }

        [TestMethod]
        public void TestMethod1a()
        {
            Validate validatorObject = new Validate();
            var max = validatorObject.GetMax(9, 3, 1);

            Assert.AreEqual(9, max);
        }
    }
}
