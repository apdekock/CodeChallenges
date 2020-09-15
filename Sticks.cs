using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Sticks
    {
        // Complete the cutTheSticks function below.
        public static int[] cutTheSticks(int[] arr)
        {
            var result = new List<int>();
            int cutcount = 0;
            while (arr.Max() > 0)
            {
                int cutLenght = arr.Where(x => x > 0).Min();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] - cutLenght >= 0)
                    {
                        arr[i] = arr[i] - cutLenght;
                        cutcount++;
                    }
                }

                result.Add(cutcount);
                cutcount = 0;
            }
            return result.ToArray();
        }

    }
}
