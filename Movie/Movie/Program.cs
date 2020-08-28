/// chapter 8     chad marshall     Movie     5/10/2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Movie
{
    class MainClass
    {
        public static void Main(/*ref string movie*/)// the "proving" method
        {
            string movie;
            int time;
            string UserInput;
            Console.WriteLine(" enter your movie...");
            movie = Convert.ToString(ReadLine());
            WriteLine("Would you like to enter the time for the movie, yes or no?");
            UserInput = ReadLine();
            switch (UserInput)
            {
                case "yes":
                    WriteLine("Enter the time in minuites");
                    time = Convert.ToInt32(ReadLine());
                    film(movie, time);
                    break;
                case "no":
                    film(movie);
                    break;
                default:
                    WriteLine("Error");
                    break;
            }
            
            ReadLine();
        }
        public static void film(string movie, int time = 90)// method that displays 2 parameters
        {

            Console.WriteLine("The movie is called: {0} ", movie);
            Console.WriteLine("The running time is: {0}", time);
        }
    }
}
