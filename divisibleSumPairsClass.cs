using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class divisibleSumPairsClass
    {
        // Complete the divisibleSumPairs function below.
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int result = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
