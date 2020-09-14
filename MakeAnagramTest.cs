using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class MakeAnagramTest
    {
        [TestMethod]
        public void TestMethodExample()
        { 
            Assert.AreEqual(2, MakeAnagram.makeAnagram("cde", "dcf"));
        }

        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(4, MakeAnagram.makeAnagram("cde", "abc"));
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(30, MakeAnagram.makeAnagram(
                "fcrxzwscanmligyxyvym", 
                "jxwtrhvujlmrpdoqbisbwhmgpmeoke"
            ));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, MakeAnagram.makeAnagram("showman", "woman"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(40, MakeAnagram.makeAnagram("bugexikjevtubidpulaelsbcqlupwetzyzdvjphn", "lajoipfecfinxjspxmevqxuqyalhrsxcvgsdxxkacspbchrbvvwnvsdtsrdk"));
        }
    }
}
