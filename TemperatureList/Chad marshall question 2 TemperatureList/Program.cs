/// chad marshall question 2 temperaturlist 1/10/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Chad_marshall_question_2_TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] days = new int[7];/// varable for number of days
            int x;/// i dont know what this is but it works.
            int sum = 0;/// added total
            int average;/// the average
            string inputString;/// a string for loop
            for (x = 0; x < days.Length; ++x)/// main loop
            {
                Write("enter the temperature in degrees centigrade,  day {0} : ", x + 1);/// user input
                inputString = ReadLine();/// displays string
                days[x] = Convert.ToInt32(inputString);/// converts into int
                sum += days[x];/// difines sum
            }
            average = sum / 7;/// difines average
            WriteLine("\n--------------------------------------------");/// neat seperation line
            WriteLine("The average is {0} degrees centigrade", average);/// displays average
            for (x = 0; x < days.Length; ++x)/// "negative" loop for difference
                if(days[x] < average)
                    WriteLine("{0} degrees - {1} degrees centigrade below average", days[x], Math.Abs(days[x] - average));
            for (x = 0; x < days.Length; ++x)/// "positive" loop for sum
                if (days[x] > average)
                    WriteLine("{0} degrees - {1} degrees centigrade above average", days[x], Math.Abs(average - days[x]));
            ReadLine();/// a readline
        }
    }
}
