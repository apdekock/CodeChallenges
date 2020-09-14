using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class MaximumSubArrayTest
    {
        [TestMethod()]
        public void TestMethodExample()
        {
            int[] expectedResult = new int[] { 16, 20 };

            int[] arr = new int[] { -1, 2, 3, -4, 5, 10 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod0()
        {
            int[] expectedResult = new int[] { 10, 10 };

            int[] arr = new int[] { 1, 2, 3, 4 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod1()
        {
            int[] expectedResult = new int[] { 10, 11 };

            int[] arr = new int[] { 2, -1, 2, 3, 4, -5 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            int[] expectedResult = new int[] { -1, -1 };

            int[] arr = new int[] { -2, -3, -1, -4, -6 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            int[] expectedResult = new int[] { 1, 1 };

            int[] arr = new int[] { 1 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            int[] expectedResult = new int[] { -1, -1 };

            int[] arr = new int[] { -1, -2, -3, -4, -5, -6 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod5()
        {
            int[] expectedResult = new int[] { 1, 1 };

            int[] arr = new int[] { 1, -2 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod6()
        {
            int[] expectedResult = new int[] { 6, 6 };

            int[] arr = new int[] { 1, 2, 3 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMethod7()
        {
            int[] expectedResult = new int[] { -10, -10 };

            int[] arr = new int[] { -10 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }
        [TestMethod()]
        public void TestMethod8()
        {
            int[] expectedResult = new int[] { 5, 6 };

            int[] arr = new int[] { 1, -1, -1, -1, -1, 5 };

            int[] actualResult = MaximumSubArray.maxSubarray(arr);

            AssertResults(expectedResult, actualResult);
        }

        private static void AssertResults(int[] expectedResult, int[] actualResult)
        {
            for (int i = 0; i < actualResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

    }
}