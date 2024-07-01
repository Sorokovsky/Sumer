using System;
// Variant 19
namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, h = 2;
            Console.Write("Введіть число a: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть число b: "); b = Convert.ToInt32(Console.ReadLine());
            for(int x = 0; x < 8; x += h)
            {
                double y = 0;
                if(1 <= x && x < 2)
                {
                    y = a + b * Math.Pow(x, 3);
                }
                else if(2 <= x && x < 3)
                {
                    y = a * Math.Pow(Math.Sin(x + b), 3);
                }
                else if(3 <= x && x < 4)
                {
                    y = Math.Sqrt(Math.Abs(a + b * Math.Pow(x, 3)));
                }
                else if(4 <= x && x < 5)
                {
                    y = a * Math.Log(Math.Abs(b + 2 * a * x));
                }
                else if(5 <= x && x < 6)
                {
                    y = Math.Pow(Math.E, a * Math.Sin(x));
                }
                Console.WriteLine("x: " + x + ", y: " + y);
            }
            Console.ReadLine();
        }
    }
}
