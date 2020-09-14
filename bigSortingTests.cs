using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HackerRank.Tests
{
    [TestClass()]
    public class bigSortingTests
    {
        [TestMethod()]
        public void bigSortingTestOne()
        {
            var expected = new string[] {
            "1",
            "2",
            "100",
            "111",
            "200",
            "3084193741082937",
            "3084193741082938",
            "12303479849857341718340192371"
             };

            var input = new string[] {
            "1",
            "2",
            "100",
            "12303479849857341718340192371",
            "3084193741082937",
            "3084193741082938",
            "111",
            "200" };

            var actual = bigSortingClass.bigSorting(input);


            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void bigSortingTestTwo()
        {
            string inputFile = @"C:\Temp\inputBS1.txt";
            var inputArr = ReadFile(inputFile);
            string outputFile = @"C:\Temp\outputBS1.txt";
            var expected = ReadFile(outputFile);


            var actual = bigSortingClass.bigSorting(inputArr);


            CollectionAssert.AreEqual(expected, actual);

        }

        private static string[] ReadFile(string FileName)
        {
            FileInfo inputFile = new FileInfo(FileName);
            var inputStringList = new List<string>();
            StreamReader streamReader = inputFile.OpenText();
            while (!streamReader.EndOfStream)
            {
                inputStringList.Add(streamReader.ReadLine());
            }

            return inputStringList.ToArray();
        }
    }
}