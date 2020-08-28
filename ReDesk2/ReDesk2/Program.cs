/// chad marshall         5/12/16        Desk2         chapter 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ReDesk2
{
    class Program 
    {
        static void Main(string[] args)
        {
            int drawerNumumber = 0;/// int for drawer number
            string DeskType;// type of wood
            double price;/// price
            NumberOfDrawers(out drawerNumumber);/// calling method for drawers
            WoodType(out DeskType);// calling the type of wood

            Price(ref drawerNumumber, ref DeskType, out price);/// calling the price 

            Details(ref drawerNumumber, ref DeskType, ref price);/// calling details
            ReadLine();
        }
        static void NumberOfDrawers(out int drawerNum)// method for number of drawers
        {
            Write("How many drawers in the desk?");//a writeline
            drawerNum = Convert.ToInt32(ReadLine());

        }
        static void WoodType(out string woodType)// the type of wood
        {
            WriteLine("What is the type of wood?\n[m] Mahogany\n[o] Oak\n[p] Pine");// another writeline
            woodType = ReadLine();

        }
        static void Price(ref int drawers, ref string wood, out double cost)
        {
            double woodPrice = 0;
            double drawerPrice = 30;

            switch (wood)
            {
                case "p":
                    woodPrice = 100;
                    break;
                case "o":
                    woodPrice = 140;
                    break;
                default:
                    woodPrice = 180;
                    break;
            }

            cost = (drawers * drawerPrice) + woodPrice;

        }
        static void Details(ref int drawerNum, ref string type, ref double price)
        {
            switch (type)
            {
                case "p":
                    type = "Pine Wood";
                    break;
                case "o":
                    type = "Oak Wood";
                    break;
                case "m":
                    type = "Mahogany Wood";
                    break;
                default:
                    type = "Other";
                    break;
            }
            WriteLine("Details:\nNumber of Drawers: {0}\nWood Type: {1}\nTotal Cost: {2}", drawerNum, type, price.ToString("c"));
        }
    }
}
