using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class SortMin
    {
        // Complete the minimumSwaps function below.
        public static int minimumSwapsOne(int[] arr)
        {
            int result = 0;

            int lastIndex = arr.Length;
            for (int i = 0; i < lastIndex; i++)
            {
                int minValue = arr[i];
                int minValueIndex = i;

                int maxValue = arr[i];
                int maxValueIndex = i;

                for (int j = i + 1; j < lastIndex; j++)
                {
                    if (minValue > arr[j])
                    {
                        minValueIndex = j;
                        minValue = Math.Min(minValue, arr[j]);
                    }
                    if (maxValue < arr[j])
                    {
                        maxValueIndex = j;
                        maxValue = Math.Max(maxValue, arr[j]);
                    }
                }

                if (minValue != arr[i])
                {
                    int holder = arr[i];
                    arr[i] = arr[minValueIndex];
                    arr[minValueIndex] = holder;
                    result++;
                    if (i == maxValueIndex)
                    {
                        maxValueIndex = minValueIndex;
                    }
                }
                if (maxValue != arr[lastIndex - 1])
                {
                    int holder = arr[lastIndex - 1];
                    arr[lastIndex - 1] = arr[maxValueIndex];
                    arr[maxValueIndex] = holder;
                    result++;
                }

                lastIndex--;
            }
            return result;
        }

        public static int minimumSwaps(int[] arr)
        {
            // Initialise count variable 
            int count = 0;
            int i = 0;

            while (i < arr.Length)
            {
                // If current element is 
                // not at the right position 
                if (arr[i] != i + 1)
                {
                    while (arr[i] != i + 1)
                    {
                        // Swap current element 
                        // with correct position 
                        // of that element 
                        int temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        count++;
                    }
                }

                // Increment for next index 
                // when current element is at 
                // correct position 
                i++;
            }
            return count;
        }
    }
}
