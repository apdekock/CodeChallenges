using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class KangaRooClass
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            //x start position
            //v jump distance 

            int positionK1 = x1;
            int positionK2 = x2;
            int difference = 0;
            if (x1 > x2)
            {
                difference = positionK1 - positionK2;
            }
            else
            {
                difference = positionK2 - positionK1;
            }

            //Note: The two kangaroos must land at the same location after making the same number of jumps.
            for (int i = 0; i < 1000; i++)
            {
                positionK1 += v1;
                positionK2 += v2;

                if (x1 > x2)
                {
                    if (difference < positionK1 - positionK2) { return "NO"; }
                }
                else
                {
                    if (difference < positionK2 - positionK1) { return "NO"; }
                }
                if (positionK1 == positionK2)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
