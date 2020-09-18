using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LoveMysteryTests
    {
        [TestMethod()]
        public void theLoveLetterMysteryTest1()
        {
            Assert.AreEqual(2, LoveMystery.theLoveLetterMystery("abc"));
        }
        [TestMethod()]
        public void theLoveLetterMysteryTestAll()
        {
            Assert.AreEqual(0, LoveMystery.theLoveLetterMystery("abcba"));
            Assert.AreEqual(4, LoveMystery.theLoveLetterMystery("abcd"));
            Assert.AreEqual(2, LoveMystery.theLoveLetterMystery("cba"));
        }
    }
}