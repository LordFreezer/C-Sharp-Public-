using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace BorderDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// origional chap program:
            /*DisplayWithBorder("Ed");
            DisplayWithBorder("Theodore");
            DisplayWithBorder("Jennifer Ann");
            ReadLine();*/
            /// my version:
            string inputname;
            WriteLine("Enter your name...");
            inputname = ReadLine();
            DisplayWithBorder(inputname);
            ReadLine();
            /// i like this one better
        }
        private static void DisplayWithBorder(string word)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine();
            WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine("\n\n");
        }
    }
}
