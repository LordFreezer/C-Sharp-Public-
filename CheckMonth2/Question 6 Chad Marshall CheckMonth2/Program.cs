/*Chaud Marshall      10/23/15     CheckMonth2*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Question_6_Chad_Marshall_CheckMonth2
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine(" Enter a month ..... ");
            int month = Convert.ToInt32(ReadLine());
            WriteLine(" Enter day of month.....");
            int day = Convert.ToInt32(ReadLine());
            if (month > 12 || month < 1)
                WriteLine("The month is invalid");

            else if ((day > 31) || (day < 1))
                WriteLine("This day is invalid");

            else if ((month == 2) && (day > 29))
                WriteLine("The day is invalid");

            else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day > 30))
                WriteLine("The day is invalad for this month");

            else if ((month == 7) && (day == 25))
                WriteLine("My birthday is definitely valid" );

            else WriteLine("The month {0} and day {1} is  valid ", month, day);
            ReadLine();
        }
    }
}