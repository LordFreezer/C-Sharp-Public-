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
            int idNum;
            string Input;
            const int LOW = 1000;
            const int HIGH = 9999;
            Write("Enter an ID number:  ");
            Input = ReadLine();
            idNum = Convert.ToInt32(Input);
            while (idNum < LOW || idNum > HIGH)
            {
                WriteLine("{0} is an invalid ID number", idNum);
                Write("ID number must be");
                WriteLine("Between {0} and {1} inclusive", LOW, HIGH);
                Write("Enter an ID number: ");
                Input = ReadLine();
                idNum = Convert.ToInt32(Input);
            }

            WriteLine("ID number {0} is valid", idNum);
            ReadLine();


        }
    }
}
