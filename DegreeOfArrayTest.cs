using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestClass]
    public class DegreeOfArrayTest
    {
        [TestMethod]
        public void TestMethod0()
        {
            var list = new List<int>() { 1, 2, 1, 3, 2 };

            Assert.AreEqual(2, DegreeOfArray.degreeOfArray(list));
        }

        [TestMethod]
        public void TestMethod1()
        {
            var list = new List<int>() { 1, 2, 5, 3, 2, 5 };

            Assert.AreEqual(4, DegreeOfArray.degreeOfArray(list));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var list = new List<int>() { 1, 2, 2, 3, 1 };

            Assert.AreEqual(2, DegreeOfArray.degreeOfArray(list));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var list = new List<int>() { 1, 2, 2, 3, 1, 4, 2 };

            Assert.AreEqual(6, DegreeOfArray.degreeOfArray(list));
        }
    }
}
