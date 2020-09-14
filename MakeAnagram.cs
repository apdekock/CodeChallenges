using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class MakeAnagram
    {
        // Complete the makeAnagram function below.
        public static int makeAnagram(string a, string b)
        {
            var firstListDictionary = GetDictionary(a);
            var secondListDictionary = GetDictionary(b);

            var inAnotInB = a.Except(b).ToList();
            int deletionsFromFirstList = 0;
            foreach (var deleteLetter in inAnotInB)
            {
                if (firstListDictionary.ContainsKey(deleteLetter.ToString()))
                {
                    deletionsFromFirstList += firstListDictionary[deleteLetter.ToString()];
                }
            }

            int deletionsFromSecondList = 0;
            foreach (var item in secondListDictionary.Keys)
            {
                if (firstListDictionary.ContainsKey(item))
                {
                    deletionsFromSecondList += Math.Abs(secondListDictionary[item] - firstListDictionary[item]);
                }
                else
                {
                    deletionsFromSecondList += secondListDictionary[item];
                }
            }
            return deletionsFromFirstList + deletionsFromSecondList;
        }

        private static Dictionary<string, int> GetDictionary(string b)
        {
            var secondListDictionary = new Dictionary<string, int>();
            for (int i = 0; i < b.Length; i++)
            {
                string key = b[i].ToString();
                if (!secondListDictionary.ContainsKey(key))
                {
                    secondListDictionary.Add(key, 0);
                }
                int count = secondListDictionary[key];
                secondListDictionary[key] = count + 1;
            }

            return secondListDictionary;
        }
    }
}
