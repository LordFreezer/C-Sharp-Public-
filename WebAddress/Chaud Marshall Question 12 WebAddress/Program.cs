///Chaud Marshall Question 12 WebAddress 12/9/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Chaud_Marshall_Question_12_WebAddress
{
    class Program
    {
        static void Main(string[] args)/// -------------------------------------------------------------->
        {   int ChadFromAccounting = 0;/// varaible for placeholder with an obligatory Death Note reference,         https://www.youtube.com/watch?v=mRpBJZek3L8
            int EspeciallyChadFromAccounting = 0;///varable for loop that works with the string 'buesness'
            string HyperLink = "wwww.";/// string for website
            string Buesness;
            WriteLine(" Enter a business name....");/// prompt user for website name
            WriteLine("                     ");
            Buesness = ReadLine();
            while (ChadFromAccounting == 0)/// while loop
            {
                if (!(Buesness[EspeciallyChadFromAccounting]).Equals(' '))/// if statement
                {
                    HyperLink = HyperLink + Buesness[EspeciallyChadFromAccounting];
                }
                ++EspeciallyChadFromAccounting;/// loop
                if (EspeciallyChadFromAccounting >= Buesness.Length)/// if statment
                {
                    ++ChadFromAccounting;
                }
            }
            WriteLine("                            ");
            Write("Your new domain is : ");/// introduces new website
            WriteLine(HyperLink + ".Weebly.com");
            WriteLine(" That will be $9.99 a month for the starter package or pay $100 for 3 years for the premium bundle!");/// my awsome rip off domain prices
            ReadLine();
        }
    }
}
