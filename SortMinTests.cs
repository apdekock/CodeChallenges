using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class SortMinTests
    {
        [TestMethod()]
        public void minimumSwapsTest0()
        {
            int expected = 3;

            int[] arr = new int[] { 4, 3, 1, 2 };

            int actual = SortMin.minimumSwaps(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void minimumSwapsTest1()
        {
            int expected = 3;

            int[] arr = new int[] { 2, 3, 4, 1, 5 };

            int actual = SortMin.minimumSwaps(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void minimumSwapsTest2()
        {
            int expected = 3;

            int[] arr = new int[] { 1, 3, 5, 2, 4, 6, 7 };

            int actual = SortMin.minimumSwaps(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}