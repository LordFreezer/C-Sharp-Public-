using System;
using static System.Console;
namespace ChadMarshall
{                                      /*please excuse my slopy code, I was about to go to bed then the solution to this problem just hit me. One hour later and Im finished with No.6.*/
    class MilesToKilometersInteractive
    {
        static void Main(string[] args)
        {
            const double MILES_TO_KM = 1.6;
            string MilesAsString;
            double Miles;
            double total;
            Write("enter how many miles you want to convert...");
            MilesAsString = ReadLine();
            Miles = Convert.ToDouble(MilesAsString);
            total = Miles * MILES_TO_KM;
            WriteLine("with there being {0} kilometers in a mile, {1} mile is equalivent to {2} kilometers."
                , MILES_TO_KM, Miles.ToString(""),
                total.ToString(""));

            ReadLine();
        }
    }
}
