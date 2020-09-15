using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class ServiceLane
    {
        public static int[] serviceLane(int n, int[][] cases)
        {             
            var result = new List<int>();

            var input = cases[0];

            for (int i = 1; i < cases.Length; i++)
            {
                int minimumWidth = int.MaxValue;
                for (int j = cases[i][0]; j <= cases[i][1]; j++)
                {
                    minimumWidth = Math.Min(minimumWidth, input[j]);
                }
                result.Add(minimumWidth);
            }

            return result.ToArray();
        }
    }
}
