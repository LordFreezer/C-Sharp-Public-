using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo1_chad_marshall_chapter_6
{
    class ArrayDemo1
    {
        static void Main(string[] args)
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45 };
            for (int x = 0; x < payRate.Length; ++x)
                WriteLine("Payrate {0} is {1}",
                    x, payRate[x].ToString("c"));
            ReadLine();
        }
    }
}
