using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MortgageApplicationProject
{
    public class MortgageApplication
    {
        public static void Main(string[] args)
        {
            int creditScore = 0;
            string applicantName = "";
            char userInput = 'n';
            Console.WriteLine("** CSCC Mortgage Company **");
            Console.Write("\nWould you like to run this program [y, n]? ");
            userInput = Convert.ToChar(Console.ReadLine());

            while (!(userInput == 'N' || userInput == 'n'))
            {
                Console.Write("Please enter the applicant's name: ");
                applicantName = Console.ReadLine();
                Console.Write("Enter credit score: ");
                creditScore = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Applicant applicant = new Applicant(applicantName, creditScore, false);
                    Console.WriteLine("{0} is {1}", applicantName, applicant.Status);
                }
                catch (ArgumentException anyException)
                {
                    Console.WriteLine(anyException.Message);
                }
                Console.Write("Would you like to run this program [y, n]? ");
                userInput = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Please press the key to terminate the program.");
            Console.ReadLine();
        }
    }
}