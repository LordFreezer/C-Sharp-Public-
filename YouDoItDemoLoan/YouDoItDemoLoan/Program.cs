using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace YouDoItDemoLoan
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            aLoan.LastName = "Mission Control";
            aLoan.LoanAmount = 10000.0;
            aLoan.LoanNumber = 231312;
            WriteLine("Loan #{0} for ${1} is for {2}", aLoan.LoanNumber, aLoan.LoanAmount, aLoan.LastName);
            ReadLine();
        }
    }
}
