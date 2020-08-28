using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_PhoneCall
{
    class Program
    {
        private static double CalcPhoneCallPrice (int minuites, double rate)
        {
            const double BASE_FEE = 0.25;
            double callFee = BASE_FEE + minuites * rate;
            return callFee;
        }
        static void Main()
        {
            int[] callLengths = { 2, 5 };
            double[] rates = {0.03, 0.12 };
            double priceOfCall;
            WriteLine("{0, 10}{1, 10}{2, 10}", "Minuites", "Rate", "price");
            for (int x = 0; x < callLengths.Length; ++x)
                for(int y = 0; y < rates.Length; ++y)
                {
                    priceOfCall = CalcPhoneCallPrice(callLengths[x], rates[y]);
                    WriteLine("{0, 10}{1, 10}{2, 10}", callLengths[x], rates[y], priceOfCall.ToString("C"));
                }
            ReadLine();
        }
    }
}
