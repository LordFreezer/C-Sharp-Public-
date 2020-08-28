/*Chaud Marshall      10/23/15     Twitter*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Question_2_Chad_Marshall_Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int HIGH = 140; /// the constant value for how long a message can be
            WriteLine("Enter your message...");///writeline statement for the user input
            String textString = ReadLine();
            int text = textString.Length;/// defining the "text" varaible with .length method
            if (text < HIGH)/// if statement
                WriteLine(" Your message was sent!  ");/// positive outout
            else/// else statemnt
                WriteLine(" Your message is too long. message cannot be sent ");/// negative output
            ReadLine();

        }
    }
}
