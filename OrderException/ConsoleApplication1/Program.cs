using System;// chad marshall. orderexceptiondemo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;  
using static System.Console;
namespace OrderExceptionDemo
{
    class orderException
    {
        static void Main(string[] args)
        {
            double num1;
            double 
            try
            {
                if (!(double.TryParse(Console.ReadLine(), out num1)))
                    throw new FormatException("Enter only numbers...no letters!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                num1 = 0;
                if (num1 < 0.0)//error
                {
                    Console.WriteLine("The Number has to be positive");
                    Sqrt = 0; //error
                }
                else
                {
                  
            }
        }
    }
}
