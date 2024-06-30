using System;
// Variant 19
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0.5;
            double b = -0.5;
            double x = 0.61;
            double y = 1.2;
            Console.WriteLine("c = " + c);
            Console.WriteLine("b = " + b);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("P = " + P(c, b, x, y));
            Console.WriteLine("S = " + S(x, b));
            Console.ReadKey();
        }

        static double P(double c, double b, double x, double y)
        {
            double sinArgument = Math.Abs(c * Math.Pow(x, 2) + b * Math.Pow(y, 2));
            double sin = Math.Sin(sinArgument);
            double upper = Math.Pow(sin, 3);
            double down = Math.Pow(Math.Abs(c * Math.Pow(x, 3) + b * Math.Pow(y, 2)), 1 / 3);
            double tan = Math.Tan(c * Math.Pow(x, 3) + b * Math.Pow(y, 2));
            double result = (upper / down) + tan;
            return result;
        }

        static double S(double x, double b)
        {
            double cos = Math.Cos(Math.Pow(x, 3));
            double first = Math.Pow(cos, 2);
            double second = x * Math.Sqrt(Math.Pow(x - b, 2));
            return first - second;
        }
    }
}
