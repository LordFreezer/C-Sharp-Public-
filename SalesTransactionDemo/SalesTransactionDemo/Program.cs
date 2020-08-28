///chad marshall  1 8/30/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SalesTransactionDemo
{
    class SalesTransactionOne
    {
        string FirstName;
        string LastName;
        double SaleAmount;
        double Rate;
        double Commission;
        public SalesTransactionOne(string firstname, string lastname, double saleAmount, double rate,double commission)
        {

            this.FirstName = firstname;
            this.LastName = lastname;
            this.SaleAmount = saleAmount = 10000000;
            this.Rate = rate = 0.5;
            this.Commission = commission = rate * saleAmount;
            
        }
        public void Display()/// displays things
        {
            WriteLine("The total sale amount for {0} is ${1} with the rate of {2}", this.FirstName + " " + this.LastName, this.SaleAmount, this.Rate);
            WriteLine("The commission for {0} is ${1}", this.FirstName, this.Commission);
        }
        ~SalesTransactionOne()///garbage collector
        {
            ///The thing that nobody uses...
            ///clean up, clean up, everybody , everywhere
            ///clean up, clean up, everybody do your share
        }
    }
    class SalesTransactionTwo
    {
        string FirstName;
        string LastName;
        double SaleAmount;
        double Commission;
        public SalesTransactionTwo(string firstname, string lastname, double saleAmount, double commission)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.SaleAmount = saleAmount = 255600;
            this.Commission = commission = 0;
        }
        public void Display()/// displays things
        {
            WriteLine("The total sale amount for {0} is ${1} ", this.FirstName + " " + this.LastName, this.SaleAmount);
            WriteLine("The commission for {0} is ${1}", this.FirstName, this.Commission);
        }
        ~SalesTransactionTwo()///garbage collector
        {
            ///The thing that nobody uses...
            ///clean up, clean up, everybody , everywhere
            ///clean up, clean up, everybody do your share
        }
    }
    class SalesTransactionThree
    {
        string FirstName;
        string LastName;
        double SaleAmount;
        double Rate;
        double Commission;
        public SalesTransactionThree(string firstname, string lastname, double saleAmount, double rate, double commission)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.SaleAmount = saleAmount = 0;
            this.Rate = rate = 0;
            this.Commission = commission = rate * saleAmount;
        }
        public void Display()/// displays things
        {
            WriteLine("The total sale amount for {0} is ${1} with the rate of {2}", this.FirstName + " " + this.LastName, this.SaleAmount, this.Rate);
            WriteLine("The commission for {0} is ${1}", this.FirstName, this.Commission);
        }
        ~SalesTransactionThree()///garbage collector
        {
            ///The thing that nobody uses...
            ///clean up, clean up, everybody , everywhere
            ///clean up, clean up, everybody do your share
        }
    }
    class Program
    {
        static void Main()
        {
            SalesTransactionOne transaction1 = new SalesTransactionOne("Lelouch", "Vi Britannia", 10000000,0.5,0);
            transaction1.Display();
            WriteLine("");
            SalesTransactionTwo transaction2 = new SalesTransactionTwo("Slaine", "Troyard", 0, 0);
            transaction2.Display();
            WriteLine("");
            SalesTransactionThree transaction3 = new SalesTransactionThree("Ledo", "and Chamber", 0, 0, 0);
            transaction3.Display();
            WriteLine("Ledo is broke");
            ReadLine();
        }
    }
}