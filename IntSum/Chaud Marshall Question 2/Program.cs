//chad marshall SumInts chap 5 11/12/25
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaud_Marshall_Question_2
{
    class ValidID
    {
        static void Main(string[] args)
        {
            int Num;
            string Input;
            const int HIGHLIMIT = 999;
            WriteLine("Enter an integer... When finished, enter 999 to cra- I mean end the program... ");
            Input = ReadLine();
            Num = Convert.ToInt32(Input);
            int sum = 0;
            while (Num != HIGHLIMIT)
            {
                sum += Num;
                Write("Enter an integer:  ");
                Input = ReadLine();
                Num = Convert.ToInt32(Input);
            }   
                WriteLine("the total sum of the numbers entered is {0}" ,sum);
                ReadLine();     
        }
    }
}
