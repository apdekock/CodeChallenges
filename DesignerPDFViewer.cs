using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DesignerPDFViewer
    {
        // Complete the designerPdfViewer function below.
        public static int designerPdfViewer(int[] h, string word)
        {
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

            int maxHeight = 0;

            foreach (var item in word.ToCharArray())
            {
                maxHeight = Math.Max(h[charsArray.IndexOf(item)], maxHeight);
            }

            return word.Length * 1 * maxHeight;
        }
    }
}
