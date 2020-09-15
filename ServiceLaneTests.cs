using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ServiceLaneTests
    {
        [TestMethod()]
        public void serviceLaneTest1()
        {
            var input = new List<int[]>();
            input.Add(new int[] { 2, 3, 1, 2, 3, 2, 3, 3 });
            input.Add(new int[] { 0, 3 });
            input.Add(new int[] { 4, 6 });
            input.Add(new int[] { 6, 7 });
            input.Add(new int[] { 3, 5 });
            input.Add(new int[] { 0, 7 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 2, 1 }, ServiceLane.serviceLane(8, input.ToArray()));
        }

        [TestMethod()]
        public void serviceLaneTest2()
        {
            var input = new List<int[]>();
            input.Add(new int[] { 1, 2, 2, 2, 1 });
            input.Add(new int[] { 2, 3 });
            input.Add(new int[] { 1, 4 });
            input.Add(new int[] { 2, 4 });
            input.Add(new int[] { 2, 4 });
            input.Add(new int[] { 2, 3 });
            CollectionAssert.AreEqual(new int[] { 2, 1, 1, 1, 2 }, ServiceLane.serviceLane(8, input.ToArray()));
        }
    }
}