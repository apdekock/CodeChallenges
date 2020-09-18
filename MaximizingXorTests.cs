using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class MaximizingXorTests
    {
        [TestMethod()]
        public void maximizingXorTest1()
        {
            Assert.AreEqual(127, MaximizingXor.maximizingXor(11, 100));
        }

        [TestMethod()]
        public void maximizingXorTest2()
        {
            Assert.AreEqual(7, MaximizingXor.maximizingXor(10, 15));
        }
        [TestMethod()]
        public void maximizingXorTest3()
        {
            Assert.AreEqual(15, MaximizingXor.maximizingXor(1, 10));
        }
        [TestMethod()]
        public void maximizingXorTest4()
        {
            Assert.AreEqual(3, MaximizingXor.maximizingXor(5, 7));
        }
    }
}