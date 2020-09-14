using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class IceCreamParlor
    {
        // Complete the whatFlavors function below.
        private static void whatFlavors(int[] cost, int money)
        {
            Console.WriteLine(whatFlavorsCalculate(cost, money));
        }

        public static string whatFlavorsCalculate(int[] cost, int money)
        {
            var listSorted = new List<int>(cost);
            var sortArray = listSorted.ToArray();
            Array.Sort(sortArray);
            for (int i = 0; i < cost.Length; i++)
            {
                int valueToFind = money - cost[i];
                int found = Array.BinarySearch(sortArray, valueToFind);
                if (found >= 0)
                {
                    for (int j = i + 1; j < cost.Length; j++)
                    {
                        if (cost[j] == valueToFind)
                        {
                            return (i + 1) + " " + (j + 1);
                        }
                    }
                }
            }

            return string.Empty;
        }
        public static string whatFlavorsCalculateEditorial(int[] cost, int money)
        {
            for (int i = 0; i < cost.Length; i++)
            {
                for (int j = i + 1; j < cost.Length; j++)
                {
                    if (money == cost[i] + cost[j])
                    {
                        int val1 = i + 1;
                        int val2 = j + 1;
                        return val1 + " " + val2;
                    }
                }
            }

            return string.Empty;
        }
        public static string whatFlavorsCalculateKeyedEditorial(int[] cost, int money)
        {
            var keyedItems = new Dictionary<int, int>();

            for (int i = 0; i < cost.Length; i++)
            {
                int valueToFind = money - cost[i];
                if (keyedItems.ContainsKey(valueToFind))
                {
                    return (keyedItems[valueToFind] + 1) + " " + (i + 1);
                }
                keyedItems[cost[i]] = i;
            }

            return string.Empty;
        }

    }
}
