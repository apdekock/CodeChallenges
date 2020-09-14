using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class divisibleSumPairsClassTests
    {
        [TestMethod()]
        public void divisibleSumPairsTest()
        {
            int expected = 5;
            int actual = divisibleSumPairsClass.divisibleSumPairs(6,3,new int[] { 1, 3, 2 ,6, 1 ,2 });
            Assert.AreEqual(expected, actual);
        }
    }
}