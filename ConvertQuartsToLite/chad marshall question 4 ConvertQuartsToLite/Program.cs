///chad marshall qustion 4 chap 7 2/17/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_question_4_ConvertQuartsToLite
{
    class Program
    {
        static void Main()
        {
            double MyQuarts;/// defining quarts
            string QuartsAsString;/// string for user input
            double MyTotal;/// sum
            double MYQUARTSTOLITERS = 0.966353;/// quarts per liter
            Write("enter how many Quarts you want to convert...");///user input
            QuartsAsString = ReadLine();/// a readline...
            MyQuarts = Convert.ToDouble(QuartsAsString);/// coverts string to input
            MyTotal = Conversion(MyQuarts, MYQUARTSTOLITERS);/// conversionn method
            WriteLine("with there being {0} liters in a Quarts, {1} Quarts is equalivent to {2}Liters."
             , MYQUARTSTOLITERS, MyQuarts.ToString(""),
                 MyTotal.ToString(""));/// whole output
            ReadLine();
        }
        private static double Conversion(double Quarts,  double QUARTSTOLITERS)
        {
            double total = Quarts * QUARTSTOLITERS;/// userinput * constant
            return total;/// returns sum
        }
    }
}
