using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AlternatingCharacters
    {
        public static int alternatingCharacters(string s)
        {
            var result = 0;
            var arr = s.ToCharArray();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) { result++; }

            }

            return result; 
        }

    }
}
