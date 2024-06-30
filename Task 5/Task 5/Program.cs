using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введіть сторони трикутника");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = "); c = Convert.ToInt32(Console.ReadLine());
            MaxWall(ref a, ref b, ref c);
            if (c * c > a * a + b * b)
            {
                Console.WriteLine("Трикутник тупокутній");
            }
            else if (c * c == a * a + b * b)
            {
                Console.WriteLine("Трикутник Прямокутній");
            }
            else
            {
                Console.WriteLine("Трикутник Гострокутній");
            }
            Console.ReadLine();
        }

        static void MaxWall(ref int a,  ref int b, ref int c)
        {
            if(a > b && a > c)
            {
                Swap(ref a, ref c);
            }
            else if(b > a && b > c)
            {
                Swap(ref b, ref c);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
