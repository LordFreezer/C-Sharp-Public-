/// chad marshall chap 6 question 4 checkzip
using System;
namespace CheckZips.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = new int[10] { 73132, 53534, 07828, 65456, 07928, 23454, 07849, 07896, 07960, 56456 };///bank of zipcodes
            int correctZipCode;/// var for correct zip
            int input;///user input
            Console.WriteLine("Pleae enter a zip code.");/// asks for userinput
            input = int.Parse(Console.ReadLine());
            correctZipCode = Convert.ToInt32(input);///converts correct var to int
            bool found = false;/// sets found to false
            for (int i = 0; i < zips.Length; ++i)/// for loop 
            {
                if (correctZipCode == zips[i])/// if statment 
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Walmart delivers to this zip location at 10:30 AM.");// positive output
            }
            else
            {
                Console.WriteLine("Walmart does not deliver to this location.");// negative putput
            }
            Console.ReadLine();/// a readline...
        }
    }
}