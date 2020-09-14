using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class records
    {
        // Complete the breakingRecords function below.
        public static int[] breakingRecords(int[] scores)
        {
            int countMin = 0;
            int countMax = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max) { max = scores[i]; countMax++; }
                if (scores[i] < min) { min = scores[i]; countMin++; }
            }

            return new int[] { countMax - 1, countMin - 1 };
        }

    }
}
