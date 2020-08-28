using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ParameterDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            WriteLine("In Main x is {0}", x);
            DisplayReferenceParameter(ref x);
            WriteLine("In Man x is {0}", x);
            ReadLine();       
        }
        private static void DisplayReferenceParameter(ref int number)
        {
            number = 888;
            WriteLine("In method, number is {0}", number);
        }
    }
}
