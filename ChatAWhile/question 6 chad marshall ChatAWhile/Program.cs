///chad marshall chap 6 question 6 chat awhile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace question_6_chad_marshall_ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCode = new int[] { 262, 414, 608, 715, 815, 920 };/// array for area codes
            double[] perMinuteRate = new double[] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };/// array for call length
            string inputString, inputString1;/// strings for user input
            int validAreaCode;/// var for conferming that the area code is correct, a saftynet
            double totalCharge = 0, inputLength;/// total cost
            double areaCodexPerMinuteRate = 0;//var to make the math easyer
            WriteLine("Enter area code... ");/// asks for areacode
            inputString = ReadLine();
            validAreaCode = Convert.ToInt32(inputString);/// converts saftynet to int
            WriteLine("Enter the  length of the call... ");/// asks for user input
            inputString1 = ReadLine();
            inputLength = Convert.ToDouble(inputString1);/// converts call length to double
            bool found = false;
            for (int x = 0; x < areaCode.Length; ++x)/// for loop for area code
            {
                if (validAreaCode == areaCode[x])
                {
                    found = true;
                    areaCodexPerMinuteRate = perMinuteRate[x]; 
                    totalCharge = areaCodexPerMinuteRate * inputLength;// the math
                }
            }
            if (found)
            {
                WriteLine(" The call was {0} minuites long so the total is ${1}", inputLength, totalCharge);/// positive output
                WriteLine("and thank you for using sprint.");/// advertisment
            }
            else
                WriteLine(" We do not support such area code");/// negative output
            ReadLine();
        }
    }
}
