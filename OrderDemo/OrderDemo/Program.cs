using System;
public class OrderDemo
{
    public static void Main()
    {
        Order orderOne = new Order(1100, "Senior Woodaan", 10);
        Order orderTwo = new Order(1200, "Sluttlittler", 5);// or however you spell his name
        Order orderThree = new Order(1100, "Asian", 3);
        Console.WriteLine(orderOne.ToString());
        Console.WriteLine(orderTwo.ToString());
        Console.WriteLine(orderThree.ToString());
        CompareNumbers(orderOne, orderTwo);
        CompareNumbers(orderOne, orderThree);
        System.Console.ReadLine();
    }
    public static void CompareNumbers(Order orderOne, Order orderTwo)
    {
        if (orderOne.Equals(orderTwo))
            Console.WriteLine("{0} for {1} has the same order " +
                "number as " + "{2} for {3}",
                orderOne.OrderNum, orderOne.Customer,
                orderTwo.OrderNum, orderTwo.Customer);
    }

    public class Order
    {
        public int orderNum;
        public string cusName;
        public int quanity;
        public double total;
        public const double ItemPrice = 19.95;
        public Order(int ordNum, string cusName, int numOrdered)
        {
            OrderNum = ordNum;
            Customer = cusName;
            Quanity = numOrdered;
        }

        public int OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }
        public string Customer
        {
            get { return cusName; }
            set { cusName = value; }
        }
        public int Quanity
        {
            get
            {
                return quanity;
            }
            set
            {
                quanity = value;
                total = quanity * ItemPrice;
            }
        }
        public double Total
        {
            get
            {
                return total;
            }
        }
        public override string ToString()
        {
            return (GetType() + " " + OrderNum + " " + Customer + " " + Quanity +
                " @" + ItemPrice.ToString("C2") + Total.ToString("C2"));
        }

        public override bool Equals(Object e)
        {
            bool equal;
            Order temp = (Order)e;
            if (OrderNum == temp.OrderNum)
                equal = true;
            else
                equal = false;
            return equal;
        }
        public override int GetHashCode()
        {
            return OrderNum;
        }
    }
}
