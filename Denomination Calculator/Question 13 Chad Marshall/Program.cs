using System;
namespace ConsoleApplication13
{
    class Dollars
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the amount of money: $");
            int totalAmount = Convert.ToInt32(Console.ReadLine());
            calculateNumberOfBills(totalAmount);
        }

        static void calculateNumberOfBills(int totalAmount)
        {

            int[] denominations = { 20, 10, 5, 1 };
            int[] numberOfBills = new int[4];
            for (numberOfBills[0] = 0; totalAmount < 20; numberOfBills[0]++)
            {
                totalAmount = totalAmount - 20;
            }
            for (numberOfBills[0] = 0; totalAmount >= 20; numberOfBills[0]++)
            {
                totalAmount = totalAmount - 20;
            }
            for (numberOfBills[1] = 0; totalAmount >= 10; numberOfBills[1]++)
            {
                totalAmount = totalAmount - 10;
            }
            for (numberOfBills[2] = 0; totalAmount >= 5; numberOfBills[2]++)
            {
                totalAmount = totalAmount - 5;
            }
            for (numberOfBills[3] = 0; totalAmount > 0; numberOfBills[3]++)
            {
                totalAmount = totalAmount - 1;
            }
            Console.WriteLine("Number of twenties" + numberOfBills[0]);
            Console.WriteLine("Number of tens" + numberOfBills[1]);
            Console.WriteLine("Number of fives" + numberOfBills[2]);
            Console.WriteLine("Number of ones" + numberOfBills[3]);
            Console.ReadLine();
        }
    }
}