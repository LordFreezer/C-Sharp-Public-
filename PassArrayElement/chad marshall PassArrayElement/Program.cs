using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_PassArrayElement
{/// note to self: need to read pilgrim's passage
    class Program
    {/// another note to self: need to finish book of five rings
        static void Main(string[] args)
        {
            int[] someNums = { 10, 12, 22, 35 };
            int x;
            Write("\nAt beginning of Main() method...");
            for (x = 0; x < someNums.Length; ++x)
                Write("{0,6}", someNums[x]);
            WriteLine();
            for (x = 0; x < someNums.Length; ++x)
                MethodGetsOneInt(someNums[x]);
            Write("At end of Main() method..........");
            for (x = 0; x < someNums.Length; ++x)
                Write("{0, 6}", someNums[x]);
            ReadLine();
        }
        private static void MethodGetsOneInt(int OneVal)
        {
            Write("In MethodGetsOneInt() {0}", OneVal);
            OneVal = 999;
            WriteLine("     After change {0}", OneVal);
        }
    }
}
