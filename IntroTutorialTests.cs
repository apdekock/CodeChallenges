using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class IntroTutorialTests
    {
        [TestMethod()]
        public void introTutorialTest()
        {
            Assert.AreEqual(1, IntroTutorial.introTutorial(4, new int[] { 1, 4, 5, 7, 9, 12 }));
        }
    }
}