using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Variant 19(1)
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Введіть 1 число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть 2 число: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(args[0]);
            d = Convert.ToInt32(args[1]);
            Console.WriteLine(a + "+" + b + "=" + Sum(a, b));
            Console.WriteLine(c + "+" + d + "=" + Sum(c, d));
            Console.WriteLine(a + "-" + b + "=" + Different(a, b));
            Console.WriteLine(c + "-" + d + "=" + Different(c, d));
            Console.WriteLine(a + "*" + b + "=" + Multiply(a, b));
            Console.WriteLine(c + "*" + d + "=" + Multiply(c, d));
            Console.WriteLine(a + "/" + b + "=" + Divide(a, b));
            Console.WriteLine(c + "/" + d + "=" + Divide(c, d));
            Console.ReadLine();
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Different(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
