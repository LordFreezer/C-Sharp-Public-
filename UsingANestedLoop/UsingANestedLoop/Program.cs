using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsingANestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tips;
            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;
            Write("Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Write("{0, 8}", tipRate.ToString("F"));
            WriteLine();
            WriteLine("-----------------------------------------------------------");
            while(dinnerPrice <= MAXDINNER)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= MAXRATE)
                {
                    tips = dinnerPrice * tipRate;
                    Write("{0, 8}", tips.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
                ReadLine();
            }
        }
    }
}
