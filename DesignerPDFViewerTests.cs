using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class DesignerPDFViewerTests
    {
        [TestMethod()]
        public void designerPdfViewerTest()
        {
            Assert.AreEqual(28, DesignerPDFViewer.designerPdfViewer(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba"));
        }
    }
}