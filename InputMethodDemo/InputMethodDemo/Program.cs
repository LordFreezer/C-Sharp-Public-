using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace InputMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            WriteLine("after InputMethod first is {0} ", first);
            WriteLine("and second is {0} ", second);
            ReadLine();
        }
        private static void InputMethod(out int one, out int two)
        {
            string s1, s2;
            Write("Enter first integer ");
            s1 = ReadLine();
            Write("Enter second integer ");
            s2 = ReadLine();
            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s1);
        }
    }
}
