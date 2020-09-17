using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ViralAdvertising
    {
        // Complete the viralAdvertising function below.
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int cumulativeLikes = 0;
            for (int i = 0; i < n; i++)
            {
                int likes = (int)Math.Floor(shared / 2.0);
                cumulativeLikes = likes + cumulativeLikes;
                shared = likes * 3;
            }
            return cumulativeLikes;
        }

    }
}
