using System;
using static System.Console;

namespace ChadMarshall

{ 
    class Program
    {
        static void Main(string[] args)
        {
            int faren, celsius;
            Console.WriteLine("Enter the Temperature in Fahrenheit(°F) : ");
            faren = int.Parse(Console.ReadLine());
            celsius = (faren - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is(°C) : " + celsius);
            ReadLine();

        }
    }
}