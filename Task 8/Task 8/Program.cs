using System;
using System.Collections.Generic;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictoniary = new Dictionary<int, string>();
            dictoniary.Add(0, "Нуль");
            dictoniary.Add(1, "Один");
            dictoniary.Add(2, "Два");
            dictoniary.Add(3, "Три");
            dictoniary.Add(4, "Чотири");
            dictoniary.Add(5, "П'ять");
            dictoniary.Add(6, "Шість");
            dictoniary.Add(7, "Сім");
            dictoniary.Add(8, "Вісім");
            dictoniary.Add(9, "Дев'ять");
            int number;
            Console.Write("Введіть ціле число: "); number = Convert.ToInt32(Console.ReadLine());
            string name;
            if(dictoniary.TryGetValue(number, out name))
            {
                Console.WriteLine("Це цифра " + name);
            }
            else
            {
                Console.WriteLine("Це число " + number);
            }
            Console.ReadLine();
        }
    }
}
