using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace HackerRank
{
    public class bigSortingClass
    {
        public static string[] bigSorting(string[] unsorted)
        {
            //Array.Sort(unsorted, (x, y) => (x.Length == y.Length ? string.Compare(x, y) : x.Length - y.Length));
            //return unsorted;
            var orderedEnumerable = unsorted
                .OrderBy(x => x.Length)
                .ThenBy(x => x, StringComparer.Ordinal);
            return orderedEnumerable.ToArray();
        }
    }
}
