using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SmartNumber
    {
        public static bool isSmartNumber(int num)
        {
            int val = (int)Math.Sqrt(num);
            if (val * val == num)
                return true;
            return false;
        }
    }
}
