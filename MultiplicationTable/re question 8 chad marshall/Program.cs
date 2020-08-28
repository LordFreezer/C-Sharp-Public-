///chad marshall question 8 12/2/15 chapter 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace chad
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int number;
            Write("Enter an integer: ");/// user imput
            number = Convert.ToInt32(ReadLine());
            WriteLine("{0} multiplied by  any integers from 1 to 10:", number);/// multilying a number by a range
            for (int i = 1; i <= 10; i++)/// the loop that messed up my rock, paper, SMASH program
            {
                int product = i * number;
                WriteLine("\n");///magic
                Write(" {0} X {1} = {2}", i, number, product);///out put
            }
            ReadLine();/// a readline
        }
    }
}
