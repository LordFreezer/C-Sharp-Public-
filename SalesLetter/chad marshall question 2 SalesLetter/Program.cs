///chad marshall qustion 2 chap 7 2/17/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace chad_marshall_question_2_SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
        WriteLine("My contact info:");
        DisplayContactInfo();/// displays info
        WriteLine("Hill Street");/// the letter
        WriteLine("Madison, Wisconsin 53700");
        WriteLine("");
        WriteLine("March 15, 2005");
        WriteLine("");
        WriteLine("Ms.Helen Jones");
        WriteLine("President");
        WriteLine("Jones, Jones & Jones");
        WriteLine("123 International Lane");
        WriteLine("Boston, Massachusetts 01234");
        WriteLine("Dear Ms.Jones:");
        WriteLine("Thank you for accepting me in your program.I will");
        WriteLine("be able to start this comming Friday");
        WriteLine("You can contact me by:");
        DisplayContactInfo();/// displays info
        WriteLine("");
        WriteLine("");
        WriteLine("John Doe");
        WriteLine("Administrative Assistant");
        WriteLine("Please feel free to contact me at");
        DisplayContactInfo();/// displays info
            ReadLine();
        }
        private static void DisplayContactInfo()/// bridge
        {
            WriteLine("My cell number is (803) 270-142");///info
            WriteLine("My email is jiusdhfliau@cox.net");
            WriteLine("My phone number is 1-800-123-4567");
        }
    }
}
