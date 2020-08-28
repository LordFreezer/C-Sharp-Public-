/// chad marshall         auction           chapter 8               5/10/2026
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Auction
{ 
    class Program
    {
        static void Main()
        {
            int Newstring;// int for string
            double Newdouble;// double for double...
            int Newint;// int for int...
            string TheUser;// var for whatever the user enters
            string Username;// your name
            string[] items = { "a really shiny mirror", "a very expensive book" };
            Random ran = new Random();// random machine
            int item = ran.Next(0, 2);// more random machine
            WriteLine("Welcome to my Auction");// the name of our lovely establishment
            WriteLine("                          ");// spacing
            Write("Enter Your Name.... ");// your name
            Username = ReadLine();// makes your name apear
            WriteLine("");// more spacing
            WriteLine("Item for sale: '{0}' :", items[item]);// displays the item that is for sale
            WriteLine("");// more and more spacing
            WriteLine("Enter a bid");// user input for bid
            WriteLine("");// more and more and more spacing
            Write("Enter a bid above $10: ");// our rules
            TheUser = ReadLine();/// makes the var appear
            if (Int32.TryParse(TheUser, out Newint))// an if statment
            {
                Pass(Newint, Username);
            }
            else if (Double.TryParse(TheUser, out Newdouble))
            {
                Pass(Newdouble, Username);
            }
            else if (TheUser[0] == '$')
            {
                string UserString;
                UserString = TheUser.Remove(0, 1);
                Int32.TryParse(UserString, out Newstring);
                if (Newstring >= 10)
                {
                    Pass(TheUser, Username);
                }
            }
            else
            {
                WriteLine("");// statement for denied payment
                Write("We can't accept that kind of payment. ");
                ReadLine();
            }

        }

        static void Pass(int money, string name)// method for ints
        {
            if (money >= 10)// statement for successful payment
            {
                WriteLine("-------------------------");
                WriteLine("");
                WriteLine("Payment being authorized... ");
                WriteLine("You have spent ${0}!", money);
                WriteLine(" {0} received the item!", name);
                ReadLine();
            }
            else
            {
                WriteLine("");// statement for denied payment
                WriteLine("For renovation reasons, bids may not be less then $10");
                WriteLine("");
                WriteLine("------------------------");
                Write("Hit enter >> ");
                ReadLine();
                WriteLine("");
                Environment.Exit(0);
            }
        }

        static void Pass(string user, string name)
        {// statement for successful payment
            WriteLine(" Payment being authorized");
            WriteLine("You Spent {0}", user);
            WriteLine(" {0} won the auction!", name);
            ReadLine();
        }

        static void Pass(double user, string name)
        {// statement for successful payment
            if (user >= 10.0)
            {
                WriteLine(" Payment being authorized");
                WriteLine("You spent ${0}", user);
                WriteLine(" {0} Won the auction!", name);
                ReadLine();
            }

            else
            {// statement for denied payment
                Write("You Cannot Have A Bid Under 10$  ");
                ReadLine();
                WriteLine("--------------------------------------");
                Main();
            }
        }
    }
}
