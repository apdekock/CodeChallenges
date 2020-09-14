using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerRank.Tests
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void TestMethod0()
        {
            int[] a = Array.ConvertAll("1 2 3".Split(' '), aTemp => Convert.ToInt32(aTemp));
            
            Assert.AreEqual("0", BubbleSort.CalculateCountSwaps(a));
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] a = Array.ConvertAll("3 2 1".Split(' '), aTemp => Convert.ToInt32(aTemp));

            Assert.AreEqual("3", BubbleSort.CalculateCountSwaps(a));
        }
    }
}
