using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BubbleSort
    {
        // Complete the countSwaps function below.
        public static void countSwaps(int[] a)
        {
            Console.WriteLine(string.Format("Array is sorted in {0} swaps.", CalculateCountSwaps(a)));
            Console.WriteLine(string.Format("First Element: {0}", a[0]));
            Console.WriteLine(string.Format("Last Element: {0}", a[^1]));
        }

        public static string CalculateCountSwaps(int[] a)
        {
            int swapCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        int swapper = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = swapper;
                        swapCount++;
                        //swap(a[j], a[j + 1]);
                    }
                }
            }
            return swapCount.ToString();
        }
    }
}
