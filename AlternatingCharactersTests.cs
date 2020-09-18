using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class AlternatingCharactersTests
    {
        [TestMethod()]
        public void alternatingCharactersTest()
        {
            Assert.AreEqual(3, AlternatingCharacters.alternatingCharacters("AAAA"));
            Assert.AreEqual(4, AlternatingCharacters.alternatingCharacters("BBBBB"));
            Assert.AreEqual(0, AlternatingCharacters.alternatingCharacters("ABABABAB"));
            Assert.AreEqual(0, AlternatingCharacters.alternatingCharacters("BABABA"));
            Assert.AreEqual(4, AlternatingCharacters.alternatingCharacters("AAABBB"));
        }
    }
}