using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ShapesDemo
{
    abstract class GeometricFigure
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(8, 8);
            Square square = new Square(8, 8);
            Triangle triangle = new Triangle();
            Console.WriteLine("The width is {0} and the heigth is {1}", 8, 8);
            Console.WriteLine("The Area for rectangle is: {0}", rectangle.ComputeArea().ToString());
            Console.ReadLine();
        
        }
        public int height;
        public int width;
        public int heigth
        {
            get { return height; }
            set { height = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public abstract double ComputeArea();
        private static void DisplayFigureDetails(GeometricFigure shape)
        { }
    }
    class Rectangle : GeometricFigure
    {
        protected int p;
        protected int p_2;
        public Rectangle()
        {
        }
        public Rectangle(int p, int p_2)
        {
            this.p = p;
            this.p_2 = p_2;
        }
        public override double ComputeArea()
        {
            return p * p_2;
        }
    }
    class Square : Rectangle
    {
        public Square(int p, int p_2)
        {
            this.p = p;
            this.p_2 = p_2;
        }
        private static void DisplayFigureDetails(GeometricFigure Square) { }
        public void equal(int height, int width)
        {
            if (height.Equals(width))
                Console.WriteLine("{0} for {1} has the same messers " +
                height, width);
        }
    }
    class Triangle : GeometricFigure
    {
        private static void DisplayFigureDetails(GeometricFigure Triangle) { }
        public override double ComputeArea()
        {
            return width * (height / 2);
        }
    }
}
