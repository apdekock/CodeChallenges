using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HackerRank.Tests
{
    [TestClass()]
    public class WeightedUniformStringsTests
    {
        [TestMethod()]
        public void weightedUniformStringsTest1()
        {
            var expected = new string[] { "Yes", "No", "Yes", "Yes", "No" };
            var actual = WeightedUniformStrings.weightedUniformStrings("aaabbbbcccddd", new int[] { 9, 7, 8, 12, 5 });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void weightedUniformStringsTest2_1()
        {
            var expected = new string[] { "Yes", "Yes", "Yes", "Yes", "No", "No" };
            var actual = WeightedUniformStrings.weightedUniformStrings("abccddde", new int[] { 1, 3, 12, 5, 9, 10 });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void weightedUniformStringsTest4()
        {
            var input = System.IO.File.ReadAllText(@"C:\Temp\inputWUS04.txt").Split('\n');
            var output = System.IO.File.ReadAllText(@"C:\Temp\outputWUS04.txt").Split('\n');

            var inputList = new List<int>();
            for (int i = 2; i < input.Length; i++)
            {
                inputList.Add(Convert.ToInt32(input[i]));
            }

            var expected = output;
            var actual = WeightedUniformStrings.weightedUniformStrings(input[0], inputList.ToArray());
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void weightedUniformStringsTest2()
        {
            var input = System.IO.File.ReadAllText(@"C:\Temp\inputWUS02.txt").Split('\n');
            var output = System.IO.File.ReadAllText(@"C:\Temp\outputWUS02.txt").Split('\n');

            var inputList = new List<int>();
            for (int i = 2; i < input.Length; i++)
            {
                inputList.Add(Convert.ToInt32(input[i]));
            }

            var expected = output;
            var actual = WeightedUniformStrings.weightedUniformStrings(input[0], inputList.ToArray());
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}