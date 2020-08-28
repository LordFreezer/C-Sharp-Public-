///Chaud marshall chap6 question 2 IntegerFacts 1/6/16
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
            int[] scores = new int[20];
            int x;
            string inputString;
            for (x = 0; x < scores.Length; ++x)
            {
                Write("enter integers up to 100. Enter an integer greater than 100 to proceed to integer output   ", x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }
            WriteLine("\n--------------------------------------------");
            WriteLine("score in original order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0,6}", scores[x]);
            ReadLine();
        }
    }
}

