using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, h = 2;
            Console.WriteLine("Введіть число a: "); a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число b: "); b = Convert.ToInt32(Console.ReadLine());
            for(int x = 1; x < 8; x += h)
            {
                double y;
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
            }
            Console.ReadLine();
        }
    }
}
