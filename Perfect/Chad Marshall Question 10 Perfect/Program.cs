using System;/// chad marshall   question 10     chapter 5       12/7/15
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;/// trying to make tis program as small as possible
namespace Chad_Marshall_Question_10_Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("     My awsome table of perfict numbers that are less than 1,000");// meh title
            int number, sumOfNumbers = 0, i = 1;/// meh varables for loop
            WriteLine("             Perfect Numbers From 1 to 1000 are: ");/// a writeline statement stating the programs topic of purpose
            for (number = 1; number <= 1000; number++)/// loopy stuff
            {
                i = 1;/// defining varable for loop
                sumOfNumbers = 0;/// assigning sumOfnumbers a 0 as a place holder
                while (i < number)/// while loop
                {
                    if (number % i == 0)/// if statement
                        sumOfNumbers = sumOfNumbers + i; i++;/// stuff that makes the loop work, just kidding, if the number % 'i' is true to 0, then make sumOfNumber = sumOfNumber + 'i', then make the loop
                }
                if (sumOfNumbers == number)///another if statement
                {/// if statement that diplays 'number' in a writeline statement with a statement that reverts back to the topic of the program, perfect numbers.
                    WriteLine("                               ");/// writeline to add space between numbers to make program look nicer
                    WriteLine("{0} is a Perfect Number", number);/// writeline for displaying the numbers        |
                }///                     CAN YOU UN-SCRAMBLE THIS WORD????----------------------------------->  \|/
            }///                                                                                                 v
            ReadLine();///-------------------------------------------------------------------->a readline... dfnweuorl realine...
        }
    }
}