using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class ApplesTests
    {
        [TestMethod()]
        public void countApplesAndOrangesTest1()
        {

            /*
            7 11
            5 15
            3 2
            -2 2 1
            5 -6
             */
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };
            var actual = Apples.countApplesAndOranges(s, t, a, b, apples, oranges);

            CollectionAssert.AreEqual(new string[] { "1", "1" }, actual);
        }

        [TestMethod()]
        public void countApplesAndOrangesTest2()
        {

            /*
            2 3
            1 5
            1 1
            2
            -2
             */
            int s = 2;
            int t = 3;
            int a = 1;
            int b = 5;
            int[] apples = new int[] { 2 };
            int[] oranges = new int[] { -2 };
            var actual = Apples.countApplesAndOranges(s, t, a, b, apples, oranges);

            CollectionAssert.AreEqual(new string[] { "1", "1" }, actual);
        }
    }
}