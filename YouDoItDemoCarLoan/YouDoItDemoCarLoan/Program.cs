using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace YouDoItDemoCarLoan
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }
    }
    class CarLoan : Loan
    {
        public int Year { get; set; }
        public string make { get; set; }
    }
    class DemoCarLoan
    { 
        static void Main(string[] args)
        {
            CarLoan aCarLoan = new CarLoan();
            aCarLoan.LoanNumber = 342342;
            aCarLoan.LastName = "Mission Control";
            aCarLoan.LoanAmount = 200000.0;
            aCarLoan.make = "Chevy";
            aCarLoan.Year = 1957;
            WriteLine("Loan #{0} for ${1} is for {2}",
                aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("Loan #{0} is for a {1} {2}",
                aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.make);
            ReadLine();
        }
    }
}
