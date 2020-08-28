using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication5
{
    class Program
    {
        private static double GetDoubleFromUser(string prompt)// this is my safey net, so that if the user enters a 
        {                                                    //something thats in not a double, then the program will still run
            double result;
            while (true)
            {
                if (prompt != null) Write(prompt);
                var input = ReadLine();
                if (double.TryParse(input, out result)) break;
                WriteLine("Sorry, that is not a valid number. Please try again...");
            }
            return result;
        }
        static void Main()
       {
            SquareRoot x = new SquareRoot();
            try
            {
                x.Number = GetDoubleFromUser("enter any number ");
                WriteLine(Math.Sqrt(x.Number));// took me forever to figure out where to put the stupid Math.Sqrt
            }
            catch (NegativeNumberException e)
            {
                WriteLine(e.Message);
            }
            
            ReadLine();
       }
    }
    class NegativeNumberException: Exception
    {
        private static string Message = "Number can't be negative, value equals 0";
        
        public NegativeNumberException(): base(Message)
        { }
    }
    class SquareRoot
    {
        private double number;
        public double Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0)
                {
                    NegativeNumberException nne = new NegativeNumberException();
                    throw (nne);
                }
                number = value;
            }
        }
    }
}
