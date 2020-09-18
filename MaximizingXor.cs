using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MaximizingXor
    {
        // Complete the maximizingXor function below.
        public static int maximizingXor(int l, int r)
        {
            var result = 0;

            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    result = Math.Max(result, i ^ j);
                }
            }

            return result;

        }
    }
}
