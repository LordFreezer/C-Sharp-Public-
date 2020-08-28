///chad marshall qustion 6 chap 7 2/17/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chaud_marshall_question_6_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mynumber;
            Write("Enter an integer: ");/// user imput
            Mynumber = Convert.ToInt32(ReadLine());
            WriteLine("{0} multiplied by  integers from 1 to 10:", Mynumber);/// multilying a number by a range
            for (int Myi = 2; Myi <= 10; Myi++)/// the loop that messed up my rock, paper, SMASH program
            {
                DisplayMultiplicationTable(Myi, Mynumber);
            }
            ReadLine();/// a readline
        }
        private static void DisplayMultiplicationTable(int i, int number)
        {
            int product = i * number;
            WriteLine("\n");///magic
            Write(" {0} X {1} = {2}", i, number, product);///out put
        }
    }
}
