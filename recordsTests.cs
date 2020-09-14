using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class recordsTests
    {
        [TestMethod()]
        public void breakingRecordsTest1()
        {
            int[] scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int[] actual = records.breakingRecords(scores);

            int[] expected = new int[] { 4, 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void breakingRecordsTest2()
        {
            int[] scores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            int[] actual = records.breakingRecords(scores);

            int[] expected = new int[] { 2 ,4 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}