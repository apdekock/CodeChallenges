using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class MaximumSubArray
    {
        public static int[] maxSubarray(int[] arr)
        {
            int maxSubArray = 0;
            int maxSubSequence = 0;

            int subArraySum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    maxSubSequence += arr[i];
                }
                subArraySum = Math.Max(0, subArraySum + arr[i]);
                maxSubArray = Math.Max(maxSubArray, subArraySum);
            }

            if (maxSubSequence == 0) maxSubSequence = arr.Max();
            if (maxSubArray == 0) maxSubArray = arr.Max();
            return new int[2] { maxSubArray, maxSubSequence };
        }
    }
}
