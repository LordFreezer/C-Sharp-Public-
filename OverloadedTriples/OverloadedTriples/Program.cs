using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OverloadedTriples
{
    class Program
    {
        private static void Triple(int num)
        {
            const int MULT_FACOR = 7;
            WriteLine("{0} minus {1} is {2}\n",
                num, MULT_FACOR, num - MULT_FACOR);
        }
        private static void Triple(string message)
        {
            WriteLine("{0}                                              \t{0}                                               \t{0}   \n", message);
            WriteLine("- Mr.Popo dropping a gallon of LSD #TRUMP-FOR-PREZ-2K16");
        }
        static void Main()
        {
            int num = 1000;
            string message = "All these squares make a circle";
            Triple(num);
            Triple(message);
            ReadLine();
        }
    }
}
