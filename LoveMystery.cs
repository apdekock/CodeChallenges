using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LoveMystery
    {
        public static int theLoveLetterMystery(string s)
        {
            var result = 0;

            var charsArray = new List<char>();
            charsArray.Add('a');
            charsArray.Add('b');
            charsArray.Add('c');
            charsArray.Add('d');
            charsArray.Add('e');
            charsArray.Add('f');
            charsArray.Add('g');
            charsArray.Add('h');
            charsArray.Add('i');
            charsArray.Add('j');
            charsArray.Add('k');
            charsArray.Add('l');
            charsArray.Add('m');
            charsArray.Add('n');
            charsArray.Add('o');
            charsArray.Add('p');
            charsArray.Add('q');
            charsArray.Add('r');
            charsArray.Add('s');
            charsArray.Add('t');
            charsArray.Add('u');
            charsArray.Add('v');
            charsArray.Add('w');
            charsArray.Add('x');
            charsArray.Add('y');
            charsArray.Add('z');

            var paliondrome = s.ToCharArray();
            int lastIndex = s.Length;
            for (int i = 0; i < lastIndex; i++)
            {
                if (paliondrome[i] != paliondrome[lastIndex - 1])
                {
                    int index1 = charsArray.IndexOf(paliondrome[i]);
                    int index2 = charsArray.IndexOf(paliondrome[lastIndex - 1]);
                    result += Math.Abs(index2 - index1);
                }
                lastIndex--;
            }

            return result;

        }
    }
}
