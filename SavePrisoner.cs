using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SavePrisoner
    {

        // Complete the saveThePrisoner function below.
        public static int saveThePrisoner(int n, int m, int s)
        {
            int v1 = m % n;
            if (v1 == 0 & s == 1)
            {
                return n;
            }
            if (m == n) v1 = m;
            int v = v1 + s - 1;
            if (v > n) { return v - n; }
            return v;


        }
    }
}
