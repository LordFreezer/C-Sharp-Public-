using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo2
{
    class ArrayDemo2
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;
            for (x = 0; x < scores.Length; ++x)
            {
                Write("enter your score on test {0}: ",  x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }
            WriteLine("\n--------------------------------------------");
            WriteLine("score in original order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0,6}", scores[x]);
            WriteLine("\n---------------------------------------------");
            Array.Sort(scores);
            WriteLine("score in sorted order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0,6}", scores[x]);
            WriteLine("\n----------------------------------------------");
            Array.Reverse(scores);
            WriteLine("score in reverse order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0,6}", scores[x]);
            ReadLine();
        }
    }
}
