using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CorrectnessInvariant
    {
        public static int[] insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value <= A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            return A;
        }
    }
}
