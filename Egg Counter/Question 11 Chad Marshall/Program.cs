using System;
using static System.Console;

namespace ChadMarshall
{
    class Eggs
    {
        static void Main(string[] args)
        {
            string MegaManEggCountAsString;
            int MegaManEggCount;
            MegaManEggCount = 17;
            string RushEggCountAsString;
            int RushEggCount;
            RushEggCount = 45;
            string BassEggCountAsString;
            int BassEggCount;
            BassEggCount = 9001;
            string TrebleEggCountAsString;
            int TrebleEggCount;
            TrebleEggCount = 8000;
            int EggTotal;
            EggTotal = MegaManEggCount + RushEggCount + BassEggCount + TrebleEggCount;
            int EggDozen;
            EggDozen = EggTotal / 12;
            double Remainder;
            Remainder = EggTotal % 12;
            WriteLine("Mega the Chicken has {0} eggs ."
              , MegaManEggCount.ToString(""));
            ReadLine();
            WriteLine("Rush the Chicken has {0} eggs ."
             , RushEggCount.ToString(""));
            ReadLine();
                WriteLine("Bass Man the Chicken has {0} eggs ."
              , BassEggCount.ToString(""));
            ReadLine();
            WriteLine("Treble Man the Chicken has {0} eggs ."
             , TrebleEggCount.ToString(""));
            ReadLine();
            WriteLine("A total of {0} eggs is {1} dozen and {2} eggs, "
                , EggTotal, EggDozen, Remainder.ToString(""));
            ReadLine();
           





        }
    }
}