/*Chaud Marshall      10/23/15     Twitter*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Question_4_Chaud_Marshall_Hurrucane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hurricane;/// varible for hurricane
            const int H5 = 157, H4 = 130, H3 = 111, H2 = 96, H1 = 74;/// the varaibles for windspeed
            Write("Enter wind speed... ");/// the user input
            String hurricaneString = ReadLine();
            hurricane = Convert.ToInt32(hurricaneString);
            WriteLine("Your wind speed was {0} MPH", hurricane);
            /* H5 = value for a hurricane less than 157 mph
               H4 = value for a hurricane less than 130 mph
               H3 = value for a hurricane less than 111 mph
               H2 = value for a hurricane less than 96 mph
               H1 = value for a hurricane less than 74 mph
            */
            if (hurricane >= H5)
                WriteLine(" The hurricane entered is defined as a category 5 hurricane on the Saffi-Simpson Hurricane scale ");
            else if (hurricane >= H4)
                WriteLine(" The hurricane entered is defined as a category 4 hurricane on the Saffi-Simpson Hurricane scale  ");
            else if (hurricane >= H3)
                WriteLine(" The hurricane entered is defined as a category 3 hurricane on the Saffi-Simpson Hurricane scale   ");
            else if (hurricane >= H2)
                WriteLine(" The hurricane entered is defined as a category 2 hurricane on the Saffi-Simpson Hurricane scale   ");
            else if (hurricane >= H1)
                WriteLine(" The hurricane entered is defined as a category 1 hurricane on the Saffi-Simpson Hurricane scale  ");
            else
                WriteLine(" The windspeed entered does not enough wind to be concidered to be a hurricane ");
 
                ReadLine();
                ReadLine();


        }
    }
}
