using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AmbiguousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 20;
            double dNum = 4.5;
            SimpleMethod(iNum, dNum); // calls first verson
            SimpleMethod(dNum, iNum); // calls for second verson
            SimpleMethod(iNum, iNum); // error! call is AMBIGUOUS....
        }
        private static void SimpleMethod(int i, double d)
        {
            WriteLine("Method recieves int and double");
        }
        private static void SimpleMethod(double d, int i)
        {
            WriteLine("Method recieves double and int");
        }
    }
}
