// chad marshall chap 6 question 8 resort prices
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace question_8_chad_marshall_ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 200, 200, 180, 180, 160, 160, 160, 145 , 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, 145, };
            int lengthOfTime;/// length of time
            string InputString;/// string for user input
            WriteLine("Welcome to the Orange Blossom Inn!");/// greeting
            String str = new String('-', 70);
            WriteLine(str);
            WriteLine("We don't accept cash and don't offer longterm stay, so please limmit your stay less than 30 nights. Check out is on Thursday.");
            WriteLine("Prices start at $200 per night for one or two night, $180 per night for three or four nights, $160 for five, six, or seven nights, and 145 for eight or more nights.");
            WriteLine(str);
            Write("Enter how many nights you want to stay: ");/// asks for user input
            InputString = ReadLine();
            lengthOfTime = Convert.ToInt32(InputString);/// converts to int
            WriteLine("The cost is ${0} per night\nYour total cost is ${1}", prices[lengthOfTime], prices[lengthOfTime] * lengthOfTime);/// output
            ReadLine();
        }
    }
}