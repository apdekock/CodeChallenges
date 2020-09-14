using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Apples
    {
        public static string[] countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {

            int cntApples = 0;
            foreach (var apple in apples)
            {
                int v = apple + a;
                if (v >= s & v <= t)
                {
                    cntApples++;
                }
            }
            Console.WriteLine(cntApples);
            int cntOranges = 0;
            foreach (var organe in oranges)
            {
                int v = b + organe;
                if (v >= s & v <= t)
                {
                    cntOranges++;
                }
            }

            Console.WriteLine(cntOranges);

            return new string[] { cntApples.ToString(), cntOranges.ToString() };
        }
    }
}
