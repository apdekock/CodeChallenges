using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InsertionSort2
    {
        public static int[] insertionSort2(int n, int[] arr)
        {
            var j = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                j = i - 1;
                while (j >= 0 && value <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = value;
                Console.WriteLine(string.Join(" ", arr));
            }
            return arr;

        }
    }
}
