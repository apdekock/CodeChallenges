using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class BetweenTwoSetsTests
    {

        [TestMethod()]
        public void getTotalXTest()
        {
            List<int> a = new List<int>() { 2, 4 };
            List<int> b = new List<int>() { 16, 32, 96 };

            int expected = 3;
            var actual = BetweenTwoSets.getTotalX(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}