using System;
namespace ChaudMarshall
{
    class Payroll
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("       WEEKLY PAYROLL INFORMATION");
            Console.WriteLine("       --------------------------");
            Console.Write("\n       Please enter the employer's name: ");
            string empName = Console.ReadLine();
            Console.Write("\n       Please enter Social Security:");
            string empSocial = Console.ReadLine();
            Console.Write("\n       Please enter the number of hours worked this week: ");
            double hrsWorked = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n       Please enter employee's HOURLY PAY RATE: ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            double grossPay = (hrsWorked * payRate);
            double federalTaxWithheld = (0.15 * grossPay);
            double socialSecurityWithheld = (0.05 * grossPay);
            double netPay = (federalTaxWithheld + socialSecurityWithheld - grossPay);
            Console.WriteLine("\n\n       The weekly payroll information summary for: " + empName);
            Console.WriteLine("\n       Gross pay:                             {0:C2}    ", grossPay);
            Console.WriteLine("       Federal income taxes witheld:          {0:C2}      ", federalTaxWithheld);
            Console.WriteLine("       Social Security taxes witheld:         {0:C2}    ", socialSecurityWithheld);
            Console.WriteLine("       Net Pay:                               {0:C2}", netPay);
            Console.ReadLine();  
       
        }
    }
}