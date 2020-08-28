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
        public const double MINloan = 5000;
        protected double loanAmount;
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            set
            {
                if (value < MINloan)
                    loanAmount = MINloan;
                else
                    loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }
    }
    class CarLoan : Loan
    {
        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set         ///KILL ME PLZ
            {
                if (value < LOWESTINVALADnumber)
                    base.LoanNumber = value;
                else
                    base.LoanNumber = value % LOWESTINVALADnumber;
            }
        }
        private int year;
        public int Year
        {
            set
            {
                if (value < EARLIESTyear)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                    year = value;
            }
            get
            {
                return year;
            }
        }
        public string make { get; set; }
        private const int EARLIESTyear = 1886;
        private const int LOWESTINVALADnumber = 1000;
    }
    class DemoCarLoan2
    {
        static void Main(string[] args)
        {
            CarLoan aCarLoan = new CarLoan();
            aCarLoan.LoanNumber = 342342;
            aCarLoan.LastName = "Mission Control";
            aCarLoan.LoanAmount = 200000.0;
            aCarLoan.make = "Chevy";
            aCarLoan.Year = 1957;
            WriteLine("Loan #{0} for {1} is for ${2}",
                aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("Loan #{0} is for a {1} {2}",
                aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.make);
            ReadLine();
        }
    }
}