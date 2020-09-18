using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class IntroTutorial
    {
        public static int introTutorial(int V, int[] arr)
        {
            var result = 0;
            result = arr.ToList().IndexOf(V);
            return result;
        }

    }
}
