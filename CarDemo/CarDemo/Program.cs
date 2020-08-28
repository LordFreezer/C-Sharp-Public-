using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CarDemo
{
    class Car
    {
        double NewMpg, mpg2, Overload;
        string Chevy;
        public Car(string chevy, double MPG2, double overload)
        {
            this.NewMpg = 16.3;
            this.Chevy = chevy;
            this.mpg2 = MPG2 = 16.3;
            Overload = overload = NewMpg++;
            chevy = "chevy";
        }
        public void Display()
        {
            WriteLine("The gas milege for the toyota is {0} miles per gallion, the M/G after incrementation is {1}", this.mpg2, this.NewMpg);
        }
    }
    class CarTwo
    {
        double NewMpg, Overload , mpg1;
        string Toyota;
        public CarTwo(string toyota, double MPG1,double overload)
        {
            this.NewMpg = 20;
            this.Toyota = toyota;
            this.mpg1 = MPG1 = 20;
            Overload = overload = ++NewMpg;
            toyota = "toyota";   
        }
        public void Display()
        {
            WriteLine("The gas milege for the toyota is {0} miles per gallion, the M/G after incrementation is {1}",this.mpg1, this.NewMpg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarTwo car2 = new CarTwo("toyota", 0, 0);
            car2.Display();
            Car car1 = new Car("chevy", 0, 0);
            car1.Display();
            ReadLine();
        }
    }
}