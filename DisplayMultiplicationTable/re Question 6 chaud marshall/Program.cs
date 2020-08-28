///chad marshall question 6 12/2/15 chapter 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace chaud
{
    class DisplayMultiplicationTable
    {
        static void Main(string[] args)
        {
            WriteLine("                                                         ");
            WriteLine("             Chaud's Multiplication Table of awsomeness :");/// my awsome title
            for (int K = 1; K <= 10; K++) /// for loop
            {/// K = Kira
                WriteLine("\n");
                for (int L = 1; L <= 10; L++)///anoither for loop
                {
                    Write("{0,6}", K * L);/// L = Lawliet
                }/// EXTREME DEATHNOTE REFERENCES
            }
            ReadLine();/// a readline
        }
    }
}
