using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ViralAdvertisingTests
    {
        [TestMethod()]
        public void viralAdvertisingTest1()
        {
            Assert.AreEqual(9, ViralAdvertising.viralAdvertising(3));
        }
    }
}