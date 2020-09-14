using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MakeAnagram.makeAnagram("cde", "dcf"));
            //Console.WriteLine(MakeAnagram.makeAnagram("cde", "abc"));

            //BubbleSort.countSwaps(Array.ConvertAll("1 2 3".Split(' '), aTemp => Convert.ToInt32(aTemp)));
            //BubbleSort.countSwaps(Array.ConvertAll("3 2 1".Split(' '), aTemp => Convert.ToInt32(aTemp)));

            //List<List<int>> arr = new List<List<int>>();
            //arr.Add(new List<int>() { 11, 2, 4 });
            //arr.Add(new List<int>() { 4, 5, 6 });
            //arr.Add(new List<int>() { 10, 8, -12 });

            //int result = diagonalDifference(arr);

            //Console.WriteLine(result);

            //int[] arr = new int[] { 55, 48, 48, 45, 91, 97, 45, 1, 39, 54, 36, 6, 19, 35, 66, 36, 72, 93, 38, 21, 65, 70, 36, 63, 39, 76, 82, 26, 67, 29, 24, 82, 62, 53, 1, 50, 47, 65, 67, 19, 66, 90, 77 };
            //decimal total = Convert.ToDecimal(arr.Count());

            //Console.WriteLine(string.Format("{0:N6}", Math.Round(Convert.ToDecimal(arr.Count(x => x > 0)) / total, 6)));
            //Console.WriteLine(string.Format("{0:N6}", Math.Round(Convert.ToDecimal(arr.Count(x => x < 0)) / total, 6)));
            //Console.WriteLine(string.Format("{0:N6}", Math.Round(Convert.ToDecimal(arr.Count(x => x == 0)) / total, 6)));

            //staircase(6);
            //miniMaxSum(new int[] { 793810624, 895642170, 685903712, 623789054, 468592370 });
            //timeConversion("07:05:45PM")
            //var input = new List<int>() { 73, 67, 38, 33 };
            //var result = gradingStudents(input);

            //Console.WriteLine(superReducedString("aaabccddd")); //abd
            //Console.WriteLine(superReducedString("baab")); //empty string

            //Console.WriteLine(camelcase("saveChangesInTheEditor")); //5 

            //Console.WriteLine(minimumNumber(3, "Ab1")); //3
            //Console.WriteLine(minimumNumber(11, "#HackerRank")); //1
            //Console.WriteLine(minimumNumber(5, "E!%Z@")); //2
            //Console.WriteLine(birthday(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2));//2
            //Console.WriteLine(birthday(new List<int>() { 1, 1, 1, 1, 1, 1 }, 3, 2));//0
            //Console.WriteLine(birthday(new List<int>() { 4 }, 4, 1));//1
            //Console.WriteLine(catAndMouse(1, 2, 3));//Cat B
            //Console.WriteLine(catAndMouse(1, 3, 2));//Mouse C

            //Console.WriteLine(isSmartNumber(1));//true
            //Console.WriteLine(isSmartNumber(2));//false
            //Console.WriteLine(isSmartNumber(7));//false
            //Console.WriteLine(isSmartNumber(169));//true

            //Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the next prize"));//pangram

            //Console.WriteLine(WeightedUniformStrings.weightedUniformStrings("aaabbbbcccddd", new int[] { 9, 7, 8, 12, 5 }));//

            //Console.WriteLine(migratoryBirds(new int[] { 1, 2, 4, 3, 5, 4, 3, 2, 1, 3, 4 }.ToList()));//3
            //Console.WriteLine(migratoryBirds(new int[] { 1, 4, 4, 4, 5, 3 }.ToList()));//4
            //Console.WriteLine(dayOfProgrammer(1900));//12.09.1900
            //Console.WriteLine(dayOfProgrammer(1918));//26.09.1918
            //Console.WriteLine(dayOfProgrammer(2017));//13.09.2017
            //Console.WriteLine(dayOfProgrammer(2016));//12.09.2016
            //Console.WriteLine(dayOfProgrammer(1984));//12.09.1984
            //Console.WriteLine(caesarCipher("middle-Outz", 2));//okffng-Qwvb
            //Console.WriteLine(luckBalance(3, new int[][] {
            //new int[] { 5, 1 },
            //    new int[] { 2, 1 },
            //    new int[] { 1, 1 },
            //    new int[] { 8, 1 },
            //    new int[] { 10, 0 },
            //    new int[] { 5, 0 } }));//29

            //Console.WriteLine(pickingNumbers(new List<int>() { 4, 6, 5, 3, 3, 1 }));//3
            //Console.WriteLine(pickingNumbers(new List<int>() { 1, 1, 2, 2, 4, 4, 5, 5, 5 }));//5

            //Console.WriteLine(permutationEquation(new int[] { 2, 3, 1 }));//231
            //Console.WriteLine(permutationEquation(new int[] { 4, 3, 5, 1, 2 }));//13542

            //Console.WriteLine(strangeCounter(4));//6
            //Console.WriteLine(strangeCounter(1000000000000));//649267441662
            //Console.WriteLine(findDigits(12));//2
            //Console.WriteLine(findDigits(1012));//3
            //Console.WriteLine(hurdleRace(4, new int[] { 1, 6, 3, 5, 2 }));//2
            //Console.WriteLine(hurdleRace(7, new int[] { 2, 5, 4, 5, 2 }));//0

            //Console.WriteLine(pageCount(6, 5));//1
            //Console.WriteLine(pageCount(5, 4));//0
            //Console.WriteLine(pageCount(95073, 17440));//8720
            //Console.WriteLine(pageCount(6, 2));//1
            //Console.WriteLine(pageCount(6, 4));//1
            //Console.WriteLine(pageCount(7, 3));//1

            //Console.WriteLine(angryProfessor(7, new int[] { 26, 94, -95, 34, 67, -97, 17, 52, 1, 86 }));//YES
            //Console.WriteLine(angryProfessor(6, new int[] { -58, -29, -35, -18, 43, -28, -76, 43, -13, 6 }));//NO
            //Console.WriteLine(angryProfessor(2, new int[] { 19, 29, -17, -71, -75, -27, -56, -53, 65, 83 }));//NO
            //Console.WriteLine(angryProfessor(3, new int[] { -1, -3, 4, 2 }));//YES
            //Console.WriteLine(angryProfessor(2, new int[] { 0, -1, 2, 1 }));//NO
            //Console.WriteLine(angryProfessor(4, new int[] { -93, -86, 49, -62, -90, -63, 40, 72, 11, 67 }));//NO
            //Console.WriteLine(angryProfessor(10, new int[] { 23, -35, -2, 58, -67, -56, -42, -73, -19, 37 }));//YES
            //Console.WriteLine(angryProfessor(9, new int[] { 13, 91, 56, -62, 96, -5, -84, -36, -46, -13 }));//YES
            //Console.WriteLine(angryProfessor(8, new int[] { 45, 67, 64, -50, -8, 78, 84, -51, 99, 60 }));//YES
            //Console.WriteLine(angryProfessor(10, new int[] { -32, -3, -70, 8, -40, -96, -18, -46, -21, -79 }));//YES
            //Console.WriteLine(angryProfessor(9, new int[] { -50, 0, 64, 14, -56, -91, -65, -36, 51, -28 }));//YES
            //Console.WriteLine(angryProfessor(1, new int[] { 88, -17, -96, 43, 83, 99, 25, 90, -39, 86 }));//NO

            //Console.WriteLine(runningTime(new int[] { 2, 1, 3, 1, 2 }));//4
            //Console.WriteLine(runningTime(new int[] { 4, 4, 3, 4 }));//2
            //Console.WriteLine(equalizeArray(new int[] { 3, 3, 2, 1, 3 }));//2

            //Console.WriteLine(utopianTree(0));//1
            //Console.WriteLine(utopianTree(1));//2
            //Console.WriteLine(utopianTree(4));//7
            //Console.WriteLine(beautifulDays(20, 23, 6));//2
            //Console.WriteLine(beautifulDays(1, 2000000, 45684660));//2998
            //Console.WriteLine(beautifulDays(1, 2000000, 23047885));//2998



        }

        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {


        }



        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            var result = 0;
            for (int index = i; index <= j; index++)
            {
                var indexRev = String.Join("", index.ToString().Reverse());
                int val = Int32.Parse(indexRev);
                var sum = (index - val);
                if (sum % k == 0)
                {
                    result++;
                }
            }
            return result;

        }

        // Complete the utopianTree function below.
        static int utopianTree(int n)
        {
            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result += 1;
                }
                else
                {
                    result = result * 2;
                }
            }
            return result;


        }


        static int equalizeArray(int[] arr)
        {
            var groups = arr.GroupBy(x => x);
            var itemsGroupedCount = groups.ToDictionary(x => x.Key, y => y.Count());
            return arr.Count() - itemsGroupedCount.Max(x => x.Value);
        }


        // Complete the runningTime function below.
        static int runningTime(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        result++;
                    }
                }
            }


            return result;
        }


        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a)
        {
            if (a.Count(x => x <= 0) < k)
            { return "YES"; }

            return "NO";
        }


        /*
        * Complete the pageCount function below.
        */
        static int pageCount(int n, int p)
        {
            var abs1 = 0;
            var abs2 = 0;
            if (p % 2 == 0)
            {
                abs1 = Math.Abs(n - p) / 2;
                abs2 = Math.Abs(p + 1) / 2;
            }
            else
            {
                abs1 = Math.Abs(n - p + 1) / 2;
                abs2 = Math.Abs(p) / 2;
            }
            return Math.Min(abs1, abs2);
        }

        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            var max = height.Max();

            if (max > k) { return max - k; }

            return 0;

        }

        // Complete the findDigits function below.
        static int findDigits(int n)
        {
            var numbs = n.ToString();

            int count = 0;
            for (int i = 0; i < numbs.Length; i++)
            {
                int nu = Convert.ToInt32(numbs[i].ToString());
                if (nu > 0)
                {
                    if (n % nu == 0) { count++; }
                }
            }
            return count;
        }

        // Complete the quickSort function below.
        static int[] quickSort(int[] arr)
        {
            Array.Sort(arr);
            return arr;

        }

        static long strangeCounter(long t)
        {
            long incrementalShift = 2;
            const int counterInitial = 3;
            while (counterInitial * (incrementalShift - 1) < t)
            {
                incrementalShift = 2 * incrementalShift;
            }
            return counterInitial * (incrementalShift - 1) - t + 1;
        }
        static long strangeCounter1(long t)
        {
            long initialCounter = 3;

            long counter = initialCounter;

            for (long i = 1; i < t; i++)
            {
                counter--;
                if (counter == 0)
                {
                    initialCounter = initialCounter * 2;
                    counter = initialCounter;
                }
            }

            return counter;
        }

        static int[] permutationEquation(int[] p)
        {
            List<int> list = p.ToList();
            List<int> resultList = new List<int>();

            for (int index = 1; index < p.Length + 1; index++)
            {
                int pIndex = list.IndexOf(index) + 1;
                int ppIndex = list.IndexOf(pIndex) + 1;

                resultList.Add(ppIndex);
            }

            return resultList.ToArray();
        }

        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */
        public static int pickingNumbers(List<int> a)
        {
            int result = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                var diffs = a.Where(c => Math.Abs(c - a[i]) <= 1);
                var group1 = diffs.Where(f => f >= a[i]);
                var group2 = diffs.Where(f => f <= a[i]);
                result = Math.Max(group1.Count(), result);
                result = Math.Max(group2.Count(), result);
            }
            return result;
        }

        // Complete the luckBalance function below.
        static int luckBalance(int k, int[][] contests)
        {
            var importantContestsDecendingOrder = contests.Where(x => x[1] == 1).OrderByDescending(x => x[0]);

            var minimumImportantContestWins = importantContestsDecendingOrder.Take(k).Sum(s => s[0]);
            var importantLosses = importantContestsDecendingOrder.Skip(k).Sum(s => s[0]);

            var notImportantWins = contests.Where(x => x[1] == 0).Sum(s => s[0]);

            return minimumImportantContestWins - importantLosses + notImportantWins;
        }

        // Complete the caesarCipher function below.
        static string caesarCipher(string s, int k)
        {
            var alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f',
                'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            k = k % 26;
            var result = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    int indexOfLetter = alphabet.IndexOf(s.ToLower()[i]) + k;
                    if (indexOfLetter >= 26)
                    {
                        indexOfLetter = indexOfLetter - 26;
                    }
                    if (Char.IsUpper(s[i]))
                    {
                        result.AddRange(alphabet[indexOfLetter].ToString().ToUpper().ToCharArray());
                    }
                    else
                    {
                        result.Add(alphabet[indexOfLetter]);
                    }
                }
                else
                {
                    result.Add(s[i]);
                }
            }

            return string.Join("", result.ToArray());
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            DateTime result = DateTime.Now;

            if (year == 1918)
            {
                var dt = new DateTime(year, 1, 1) - new DateTime(1899, 12, 31);
                result = DateTime.FromOADate(dt.Days + 256 + 13);
            }
            else if (year == 1900)
            {
                result = new DateTime(1900, 9, 12);
            }
            else if (year > 1899)
            {
                var dt = new DateTime(year, 1, 1) - new DateTime(1899, 12, 31);
                result = DateTime.FromOADate(dt.Days + 256);
            }
            else if (year % 4 == 0) //leap year julian
            {
                result = new DateTime(year, 9, 12);
            }
            else //normal year julian
            {
                result = new DateTime(year, 9, 13);
            }

            return string.Format("{0}.{1}.{2}",
                result.Date.Day.ToString().PadLeft(2, '0'),
                result.Date.Month.ToString().PadLeft(2, '0'),
                result.Date.Year);
        }


        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            IEnumerable<IGrouping<int, int>> enumerable = arr.GroupBy(x => x).OrderBy(x => x.Key);
            var n = enumerable.OrderByDescending(x => x.Count());
            return n.First().Key;
        }


        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {


        }

        // Complete the pangrams function below.
        static string pangrams(string s)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (s.ToLower().IndexOf(alphabet[i]) < 0)
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
        public static bool isSmartNumber(int num)
        {
            int val = (int)Math.Sqrt(num);
            if (num / val == 1)
                return true;
            if (num % val == 0)
            {
                if (num % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) == Math.Abs(y - z))
            {
                return "Mouse C";
            }

            if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return "Cat B";
            }
            else
            {
                return "Cat A";
            }
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    if (j < s.Count)
                    {
                        sum += s[j];
                    }
                }
                if (sum == d) { result++; }
            }
            return result;
        }

        // Complete the marsExploration function below.
        static int marsExploration(string s)
        {
            int result = 0;
            var charArray = new char[] { 'S', 'O', 'S' };
            int pos = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (pos >= charArray.Length) { pos = 0; }
                if (s[i] != charArray[pos])
                {
                    result++;
                }
                pos++;
            }
            return result;
        }


        // Complete the minimumNumber function below.
        static int minimumNumber(int n, string password)
        {
            int result = 0;
            int lengthPassword = 0;
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";
            // Return the minimum number of characters to make the password strong
            if (password.Length < 6)
            {
                lengthPassword = 6 - password.Length;
            }

            if (password.ToCharArray().Intersect(numbers.ToCharArray()).Count() == 0)
            {
                result++;
            }
            if (password.ToCharArray().Intersect(lower_case.ToCharArray()).Count() == 0)
            {
                result++;
            }
            if (password.ToCharArray().Intersect(upper_case.ToCharArray()).Count() == 0)
            {
                result++;
            }
            if (password.ToCharArray().Intersect(special_characters.ToCharArray()).Count() == 0)
            {
                result++;
            }

            return Math.Max(result, lengthPassword);
        }

        // Complete the camelcase function below.
        static int camelcase(string s)
        {
            return s.Count(c => Char.IsUpper(c)) + 1;
        }

        // Complete the superReducedString function below.
        static string superReducedString(string s)
        {
            bool found = true;
            var arr = s.ToList();
            while (found)
            {
                found = false;
                for (int i = 1; i < arr.Count; i++)
                {
                    if (arr[i - 1] == arr[i])
                    {
                        arr.RemoveAt(i);
                        arr.RemoveAt(i - 1);
                        found = true;
                    }
                }
            }
            if (arr.Count == 0)
            {
                return "Empty String";
            }
            return string.Join(string.Empty, arr);
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            var result = new List<int>();

            foreach (var grade in grades)
            {
                int remainderOfFive = grade % 5;
                if (grade < 38)
                {
                    result.Add(grade);
                }
                else if (remainderOfFive >= 3)
                {
                    int roundedUpFive = 5 - remainderOfFive;
                    result.Add(roundedUpFive + grade);
                }
                else
                {
                    result.Add(grade);
                }
            }

            return result;
        }

        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            var date = DateTime.Parse(s);

            return date.ToString("HH:mm:ss");
        }
        static int birthdayCakeCandles(int[] ar)
        {
            int v = ar.Max();
            return ar.Count(x =>
            {

                return x == v;
            });

        }
        static void miniMaxSum(int[] arr)
        {
            long max = long.MinValue;
            long min = long.MaxValue;

            for (int index = 0; index < arr.Length; index++)
            {
                long value = 0;
                for (int j = 0; j < index; j++)
                {
                    value += arr[j];
                }
                for (int j = arr.Length - 1; j > index; j--)
                {
                    value += arr[j];
                }
                min = Math.Min(min, value);
                max = Math.Max(max, value);
            }

            Console.Write("{0} {1}", min, max);
        }
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("#".PadLeft(n - i, ' '));
                for (int j = n - i; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            var leftDiagSum = 0;
            var rightDiagSum = 0;
            for (int rowIndex = 0; rowIndex < arr.Count; rowIndex++)
            {
                int leftIndex = rowIndex;
                int rightIndex = arr[rowIndex].Count - 1 - rowIndex;

                leftDiagSum = leftDiagSum + arr[rowIndex][leftIndex];
                rightDiagSum = rightDiagSum + arr[rowIndex][rightIndex];


            }
            return Math.Abs(leftDiagSum - rightDiagSum);
        }
    }
}
