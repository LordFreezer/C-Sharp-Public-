using System;
using static System.Console;
class TaxPayer : IComparable<TaxPayer>
{
    private string ssn;
    private double grossIncome;
    private double taxOwed;
    public string SSN
    {
        get { return ssn; }
        set { ssn = value; }
    }
    public double GrossIncome
    {
        get { return grossIncome; }
        set
        {
            grossIncome = value;
            if (grossIncome < 30000)
                taxOwed = 0.15 * grossIncome;
            else
                taxOwed = 0.28 * grossIncome;
        }
    }
    public double TaxOwed
    {
        get { return taxOwed; }
    }
    public TaxPayer(string ssn, double grossIncome)
    {
        this.ssn = ssn;
        GrossIncome = grossIncome; 
    }

    public override string ToString()
    {
        return String.Format("SSN = {0}, Income = {1,11:C}, Tax Owed = {2,10:C}", ssn, grossIncome, taxOwed);
    }
    public int CompareTo(TaxPayer other)
    {
        return this.taxOwed.CompareTo(other.taxOwed);
    }

}

class TaxPayerDemo
{
    static void Main()
    {
        TaxPayer[] taxPayers = new TaxPayer[10];
        string ssn;
        double grossIncome;
        Console.WriteLine("Please enter details for 10 taxpayers\n");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Details for taxpayer #{0}", i + 1);
            Console.Write("   Enter Social Security Number : ");
            ssn = Console.ReadLine().Replace("-", ""); // get rid of any dashes
            Console.Write("   Enter Yearly Gross Income    : ");
            grossIncome = Convert.ToDouble(Console.ReadLine());
            taxPayers[i] = new TaxPayer(ssn, grossIncome);
            Console.WriteLine();
        }
        Console.WriteLine("The taxpayers and their details are\n");
        for (int i = 0; i < 10; i++) Console.WriteLine(taxPayers[i]);
        Array.Sort(taxPayers); // sorts the taxpayers in order of tax owed
        Console.WriteLine();
        Console.WriteLine("The taxpayers in order of tax owed are\n");
        for (int i = 0; i < 10; i++) Console.WriteLine(taxPayers[i]);
        Console.ReadKey();
    }
}
/// i stole snipbits from like 3 different people. kill me plz