using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_PassEntireArray
{/// note to self: need to read pilgrim's passage
    class Program
    {/// another note to self: need to finish book of five rings
        static void Main(string[] args)
        {
            int[] someNums = { 10, 12, 22, 35 };
            int x;
            Write("\nAt beginning of Main() method...");
            for (x = 0; x < someNums.Length; ++x)
                Write("{0, 6}", someNums[x]);
            WriteLine();
            MethodGetsArray(someNums);
            Write("At end of Main() method..........");
            for (x = 0; x < someNums.Length; ++x)
                Write(" {0, 6}", someNums[x]);
            ReadLine();
        }
        private static void MethodGetsArray(int[] vals)
        {
            int x;
            Write("In MethodGetsOneInt() ");
            for (x = 0; x < vals.Length; ++x)
                Write(" {0}", vals[x]);
            WriteLine();
            for (x = 0; x < vals.Length; ++x)            
                vals[x] = 888;
            Write("After change ");
            for (x = 0; x < vals.Length; ++x)
                Write(" {0}", vals[x]);
            WriteLine();
        }
    }
}
