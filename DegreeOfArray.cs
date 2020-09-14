using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class DegreeOfArray
    {
        public static int degreeOfArray(List<int> arr)
        {
            int[] arrayOfValues = arr.ToArray();

            var findDegree = new Dictionary<int, int>();

            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                int Value = arrayOfValues[i];
                if (!findDegree.ContainsKey(Value))
                {
                    findDegree.Add(Value, 0);
                }
                int count = findDegree[Value];
                findDegree[Value] = count + 1;
            }

            int minSubArray = int.MaxValue;

            int maxDegree = findDegree.Max(x => x.Value);

            var maxDegrees = findDegree.Where(x => x.Value == maxDegree);
            foreach (var item in maxDegrees)
            {
                bool valueFound = false;
                int subarrayValueCount = 0;
                for (int i = 0; i < arrayOfValues.Length; i++)
                {
                    if (arrayOfValues[i] == item.Key)
                    {
                        if (valueFound)
                        {
                            minSubArray = Math.Min(minSubArray, subarrayValueCount);
                            subarrayValueCount = 0;
                        }
                        valueFound = !valueFound;
                    }
                    if (valueFound)
                    {
                        subarrayValueCount++;
                    }
                }
            }

            return minSubArray;
        }

    }
}
