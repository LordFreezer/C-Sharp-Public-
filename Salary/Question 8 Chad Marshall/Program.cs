using System;
using static System.Console;
namespace ChadMarshall
{                                      
    class ProjectedRaisesInteractive
    {
        static void Main(string[] args)
        {
            const double SALARY_RAISE = 0.04;
            double AlexSalary;
            double ChaudSalary;
            double JeffSalary;
            string AlexSalaryAsString;
            double AlexTotal;
            string ChaudSalaryAsString;
            double ChaudTotal;
            string JeffSalaryAsString;
            double JeffTotal;
            Write("enter the basic salary for Alex...");
            AlexSalaryAsString = ReadLine();
            AlexSalary = Convert.ToDouble(AlexSalaryAsString);
            AlexTotal = AlexSalary * SALARY_RAISE + AlexSalary;
            WriteLine("With a ${0} salary raise, if Alex would earn {1} per hour, his total income would be {2}."
                , SALARY_RAISE, AlexSalary.ToString("C"),
                AlexTotal.ToString("C"));
                ReadLine();
            Write("enter the basic salary for Jeff...");
            JeffSalaryAsString = ReadLine();
            JeffSalary = Convert.ToDouble(JeffSalaryAsString);
            JeffTotal = JeffSalary * SALARY_RAISE + JeffSalary;
            WriteLine("With a ${0} salary raise, if Jeff would earn {1} per hour, his total income would be {2}."
                , SALARY_RAISE, JeffSalary.ToString("C"),
                JeffTotal.ToString("C"));
            ReadLine();
            Write("enter the basic salary for Chaud...");
            ChaudSalaryAsString = ReadLine();
            ChaudSalary = Convert.ToDouble(ChaudSalaryAsString);
            ChaudTotal = ChaudSalary * SALARY_RAISE + ChaudSalary;
            WriteLine("With a ${0} salary raise, if Chaud would earn {1} per hour, his total income would be {2}."
                , SALARY_RAISE, ChaudSalary.ToString("C"),
                ChaudTotal.ToString("C"));
            ReadLine();


        }
    }
}
