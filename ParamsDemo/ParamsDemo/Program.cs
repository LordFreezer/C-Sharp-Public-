using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { " Mark", " Paulette", " Carol", " James" };
            DisplayString(" Redhead");
            DisplayString(" George", " Maria", " Thomas");
            DisplayString(names);
            ReadLine();
        }
        private static void DisplayString(params string[] people)
        {
            foreach (string person in people)
                Write(person);
            WriteLine("\n---------------");
        }
    }
}
