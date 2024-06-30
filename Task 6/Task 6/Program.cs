
using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введіть число більше 0 і меньше 1000: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нове число: " + GetNewNumber(number));
            Console.ReadLine();
        }

        static int GetNewNumber(int number)
        {
            if (number < 1)
            {
                number = 1;
            }
            if (number >= 1000)
            {
                number = 999;
            }
            int a = number % 10, 
                b = (number % 100) / 10, 
                c = (number % 1000) / 100;
            Type integer = typeof(int);
            Array array = Array.CreateInstance(integer, 3);
            array.SetValue(a, 0);
            array.SetValue(b, 1);
            array.SetValue(c, 2);
            int result = 0;
            Array.Sort(array);
            for(int i = 0; i < array.Length; i++)
            {
                result += (int)array.GetValue(i);
                if(i != 2)
                {
                    result *= 10;
                }
            }
            return result;
        }
    }
}
