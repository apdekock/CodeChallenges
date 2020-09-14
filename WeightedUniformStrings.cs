using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class WeightedUniformStrings
    {
        // Complete the weightedUniformStrings function below.
        public static string[] weightedUniformStrings(string s, int[] queries)
        {
            var alphadict = new Dictionary<char, int>();

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphadict[alphabet[i]] = i + 1;
            }

            var uniformWeights = new HashSet<int>();

            char[] charArray = s.ToCharArray();
            int index = 0;
            while (index < charArray.Length)
            {
                var streak = charArray.Skip(index).TakeWhile(x => x == charArray[index]);
                int streakLength = streak.Count();

                for (int j = 1; j <= streakLength; j++)
                {
                    uniformWeights.Add(alphadict[charArray[index]] * j);
                }

                index = index + streakLength;
            }

            var result = new List<string>();

            for (int i = 0; i < queries.Length; i++)
            {
                if (uniformWeights.Contains(queries[i]))
                {
                    result.Add("Yes");
                }
                else
                {
                    result.Add("No");
                }
            }

            return result.ToArray();
        }
    }
}
