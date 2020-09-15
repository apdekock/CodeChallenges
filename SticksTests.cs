using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SticksTests
    {
        [TestMethod()]
        public void cutTheSticksTest()
        {
            CollectionAssert.AreEqual(new int[] { 6, 4, 2, 1 }, Sticks.cutTheSticks(new int[] { 5, 4, 4, 2, 2, 8 }));
        }
    }
}