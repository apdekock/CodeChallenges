using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class CorrectnessInvariantTests
    {
        [TestMethod()]
        public void insertionSortTest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 5, 6, 7 }, CorrectnessInvariant.insertionSort(new int[] { 7, 4, 3, 5, 6, 2 }));
        }
    }
}