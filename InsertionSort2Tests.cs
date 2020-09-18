using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class InsertionSort2Tests
    {
        [TestMethod()]
        public void insertionSort2Test()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, InsertionSort2.insertionSort2(6, new int[] { 1 ,4, 3, 5 ,6 ,2 }));
        }
    }
}