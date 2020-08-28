using System;
abstract class Salesperson
{
    protected string firstName;
    protected string lastName;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }
    protected Salesperson(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
interface ISellable
{
    void SalesSpeech();
    void MakeSale(int value);
}
class RealEstateSalesperson : Salesperson, ISellable
{
    public static readonly double CommissionRate;
    static RealEstateSalesperson()
    {
        CommissionRate = 2.0; // say
    }
    int totalValueSold = 0;
    double totalCommissionEarned = 0.0;
    public int TotalValueSold
    {
        get { return totalValueSold; }
        set { totalValueSold = value; }
    }
    public double TotalCommissionEarned
    {
        get { return totalCommissionEarned; }
        set { totalCommissionEarned = value; }
    }
    public RealEstateSalesperson(string firstName, string lastName)
    : base(firstName, lastName)
    {

    }
    public void SalesSpeech()
    {
        Console.WriteLine("I'm {0}, I sell houses", GetFullName());
    }
    public void MakeSale(int houseValue)
    {
        totalValueSold += houseValue;
        totalCommissionEarned += houseValue * CommissionRate / 100.0;
    }
}
class GirlScout : Salesperson, ISellable
{
    int boxesOfCookiesSold = 0;

    public int BoxesOfCookiesSold
    {
        get { return boxesOfCookiesSold; }
        set { boxesOfCookiesSold = value; }
    }
    public GirlScout(string firstName, string lastName)
    : base(firstName, lastName)
    {

    }
    public void SalesSpeech()
    {
        Console.WriteLine("I'm {0}, I sell boxes of cookies", GetFullName());
    }
    public void MakeSale(int boxesSold)
    {
        boxesOfCookiesSold += boxesSold;
    }

}
class SalespersonDemo
{
    static void Main()
    {
        RealEstateSalesperson resp = new RealEstateSalesperson("Senior", "Woodan");
        resp.SalesSpeech();
        resp.MakeSale(200000);
        resp.MakeSale(250000);
        resp.MakeSale(300000);
        Console.WriteLine("Total value of houses sold = ${0:N0}", resp.TotalValueSold);
        Console.WriteLine("Total commission earned @ {0}% = ${1:N2}", RealEstateSalesperson.CommissionRate, resp.TotalCommissionEarned);
        Console.WriteLine();
        GirlScout gs = new GirlScout("The Annoying", "Brat Looking through your window");
        gs.SalesSpeech();
        gs.MakeSale(10);
        gs.MakeSale(15);
        gs.MakeSale(20);
        Console.WriteLine("Total number of boxes of cookies sold = {0:N0}", gs.BoxesOfCookiesSold);
        Console.ReadKey();
    }
}
