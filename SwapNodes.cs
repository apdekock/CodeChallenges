using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SwapNodes
    {
        public static int[][] swapNodes(int[][] indexes, int[] queries)
        {
            //1. build nodes 
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            for (int level = 0; level < indexes.Length; level++)
            {
                for (int i = 0; i < indexes[level].Length; i++)
                {
                    binaryTree.Add(indexes[level][i]);
                }
            } 

            var result = new List<List<int>>();

            //2. traverse nodes
            foreach (var query in queries)
            {
                var queryResult = new List<int>();

                //travese and swop

                result.Add(queryResult);
            }

            return new int[0][];
        }


        public class BinaryTree
        {
            public Node Root { get; set; }
            public bool Add(int value)
            {
                Node before = null, after = this.Root;

                while (after != null)
                {
                    before = after;
                    if (value < after.Data) //Is new node in left tree? 
                        after = after.LeftNode;
                    else if (value > after.Data) //Is new node in right tree?
                        after = after.RightNode;
                    else
                    {
                        //Exist same value
                        return false;
                    }
                }

                Node newNode = new Node(value);

                if (this.Root == null)//Tree is empty
                    this.Root = newNode;
                else
                {
                    if (value > before.Data)
                        before.AddLeftChild(newNode);
                    else
                        before.AddRightChild(newNode);
                }

                return true;
            }
        }

        public class Node
        {
            public int Data { get; private set; }
            public Node LeftNode { get; private set; }
            public Node RightNode { get; private set; }

            public Node(int value)
            {
                this.Data = value;
            }

            public void AddLeftChild(Node node)
            {
                LeftNode = node;
            }

            public void AddRightChild(Node node)
            {
                RightNode = node;
            }
        }
    }
}
