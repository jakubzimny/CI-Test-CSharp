using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(8,Calculator.Calculator.Add(5, 3));
        }
        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(8, Calculator.Calculator.Multiply(4, 2));
        }
    }
}
