using System;

namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 6;
            Pair pair = new Pair(num1, num2);
            Rectangle rectangle = new Rectangle(num2, num1);

            Console.WriteLine("Multiply " + num1 + " on " + num2 + " = " + pair.Multiply());
            Console.Out.WriteLine("-----------------------------------------------------------");
            Console.Out.WriteLine("Rectangle size: " + num2 + "x" + num1);
            Console.Out.WriteLine("Rectangle perimeter: " + rectangle.Perimeter());
            Console.Out.WriteLine("Rectangle area: " + rectangle.Area());
        }
    }

    public class Pair
    {
        private double first { get; set; }
        private double second { get; set; }

        public Pair()
        {
            first = 0;
            second = 0;
        }

        public Pair(double first, double second)
        {
            this.first = first;
            this.second = second;
        }

        public double Multiply()
        {
            return first * second;
        }
    }

    public class Rectangle
    {
        private double a { get; set; }
        private double b { get; set; }

        public Rectangle()
        {
            a = 0;
            b = 0;
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Perimeter()
        {
            return 2 * (a + b);
        }

        public double Area()
        {
            return a * b;
        }
    }
}