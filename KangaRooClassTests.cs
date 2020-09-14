using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class KangaRooClassTests
    {
        [TestMethod()]
        public void kangarooTest1()
        {
            var actual = KangaRooClass.kangaroo(0, 3, 4, 2);
            Assert.AreEqual("YES", actual);
        }

        [TestMethod()]
        public void kangarooTest2()
        {
            var actual = KangaRooClass.kangaroo(0, 2, 5 ,3);
            Assert.AreEqual("NO", actual);
        }
    }
}