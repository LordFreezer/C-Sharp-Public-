//chad marshall TestScores chap 5 11/12/25
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaud_Marshall_Question_4
{
    class program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;
            int NumOfTest = 0;
            score = 0;
            int average;
            while (score < 101)
               {
                if (score != 101)
                {
                    sum += score;
                    NumOfTest += 1;
                    WriteLine("Enter a score... enter a score that is more than 100 to end the program  ");
                    score = Convert.ToInt32(ReadLine());
                }
                if (score > 101 || score < 0)
                    Write("Score is invalid. Press ENTER to crash the program.");    
                }
            average = sum / NumOfTest;
            WriteLine("  The total sum of the scores entered is {0} and the average is {1}", sum, average);
            ReadLine();
        }
    }
}
