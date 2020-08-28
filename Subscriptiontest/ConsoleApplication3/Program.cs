using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] newArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20.8 };
            int input;
            for (int i = 0; i < newArray.Length; i++)
            {
                try
                {
                    WriteLine("Enter in a postion of a number in the array to display it. The array only has 20 elements. Enter anything greater than 20, i dare you");
                    input = int.Parse(ReadLine());
                    WriteLine(newArray[input]);
                }
                catch (IndexOutOfRangeException e)
                {
                    WriteLine("Well, you dun-goofed");
                }
            }
        }
    }
}
