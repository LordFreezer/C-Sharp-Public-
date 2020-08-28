using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SwapProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 34, second = 712;
            Write("Before swap first is {0}", first);
            WriteLine(" and second is {0}, second", second);
            Swap(ref first, ref second);
            Write("After swap first is {0}", first);
            WriteLine(" and secon is {0}", second);
            ReadLine();
        }
        private static void Swap(ref int one, ref int two)
        {
            int temp; 
            temp = one;
            one = two;
            two = temp;           
        }
    }
}
