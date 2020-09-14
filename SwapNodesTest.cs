using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class SwapNodesTest
    {
        [TestMethod()]
        public void swapNodesTest0()
        {
            /*
                3
                2 3
                -1 -1
                -1 -1
                2
                1
                1
            */
            string[] input = new string[] { "3", "2 3", "-1 -1", "-1 -1", "2", "1", "1" };

            int n = Convert.ToInt32(input[0]);

            int[][] indexes = new int[n][];

            for (int indexesRowItr = 0; indexesRowItr < n; indexesRowItr++)
            {
                indexes[indexesRowItr] = Array.ConvertAll(input[indexesRowItr + 1].Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
            }

            int queriesCount = Convert.ToInt32(input[n + 1]);

            int[] queries = new int[queriesCount];

            for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
            {
                int queriesItem = Convert.ToInt32(input[queriesItr + n+2 ]);
                queries[queriesItr] = queriesItem;
            }

            int[][] result = SwapNodes.swapNodes(indexes, queries);

            /* 
               3 1 2
               2 1 3
            */
            Assert.AreEqual("3 1 2", string.Join(" ", result[0]));
            Assert.AreEqual("2 1 3", string.Join(" ", result[1]));
        }

        [TestMethod()]
        public void swapNodesTest1()
        {
            /*
               5
               2 3
               -1 4
               -1 5
               -1 -1
               -1 -1
               1
               2
            */
            string[] input = new string[] { "5", "2 3", "-1 4", "-1 5", "-1 -1", "-1 -1", "1", "2" };

            int n = Convert.ToInt32(input[0]);

            int[][] indexes = new int[n][];

            for (int indexesRowItr = 0; indexesRowItr < n; indexesRowItr++)
            {
                indexes[indexesRowItr] = Array.ConvertAll(input[indexesRowItr + 1].Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
            }

            int queriesCount = Convert.ToInt32(input[n + 1]);

            int[] queries = new int[queriesCount];

            for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
            {
                int queriesItem = Convert.ToInt32(input[queriesItr + n + 2]);
                queries[queriesItr] = queriesItem;
            }

            int[][] result = SwapNodes.swapNodes(indexes, queries);

            /*
               4 2 1 5 3
            */
            Assert.AreEqual("4 2 1 5 3", string.Join(" ", result[0]));
        }

        [TestMethod()]
        public void swapNodesTest2()
        {
            /*
                
            */
            Assert.Fail();
        }

        [TestMethod()]
        public void swapNodesTest3()
        {
            /*
               
            */
            Assert.Fail();
        }
    }
}