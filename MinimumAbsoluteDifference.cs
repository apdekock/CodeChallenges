using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace HackerRank
{
    public class MinimumAbsoluteDifference
    {
        // Complete the minimumAbsoluteDifference function below.
        public static int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);

            int minimumDifference = int.MaxValue;

            minimumDifference = Math.Min(minimumDifference, Math.Abs(arr[0] - arr[1]));

            int length = arr.Length;
            minimumDifference = Math.Min(minimumDifference, Math.Abs(arr[length - 1] - arr[length - 2]));

            for (int i = 1; i < length - 1; i++)
            {
                minimumDifference = Math.Min(minimumDifference,
                Math.Min(Math.Abs(arr[i] - arr[i - 1]),
                        Math.Abs(arr[i] - arr[i + 1])));
                if (minimumDifference == 0) break;
            }

            return minimumDifference;
        }
    }
}
