

///chad marshall qustion 10 chap 7 2/17/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_question_10_FlexibleArrayMetho
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[3] { 1, 2, 3 };/// arrays with integers
            int[] Array2 = new int[2] { 2, 3 };
            int[] Array3 = new int[1] { 1 };
            Display(Array1, Array2, Array3);/// the thing that displays EVERYTHING
        }
        public static void Display(int[] a, int[] b, int[] c)/// the bridge between methods
        {
            int acc = 0;/// vars for sums
            int accc = 0;
            int acccc = 0;       
            WriteLine("\n\nThe Numbers in this array are: \n");
            foreach (int i in a)
            {
                Write("\t{0}", i);/// displays each integer
            }
            foreach (int j in a)
                acc += j;
            WriteLine("");
            WriteLine("Their sum is {0}", acc);/// diplays sum
            WriteLine("\n\nThe Numbers in this array are: \n");
            foreach (int i in b)
            {
                Write("\t{0}", i);/// ditto
            }
            foreach (int j in b)
                accc += j;
            WriteLine("");
            WriteLine("Their sum is {0}", accc);///ditto
            WriteLine("\n\nThe Numbers in this array are: \n");
            foreach (int i in c)
            {
                Write("\t{0}", i);///ditto
            }
            foreach (int j in c)
                acccc += j;
            WriteLine("");
            WriteLine("Their sum is {0}", acccc);///ditto
            int total = acc + accc + acccc;
            WriteLine("");
            WriteLine("The total sum of all of the integers is {0}", total);
            ReadLine();
        }
    }
}
