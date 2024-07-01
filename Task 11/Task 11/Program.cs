using System;
// Variant 19
namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введіть кількість елементів: "); n = Convert.ToInt32(Console.ReadLine());
            if(n < 1)
            {
                n = 1;
            }
            int[] array = new int[n];
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            Console.WriteLine("Масив: " + string.Join(", ", array));
            Console.WriteLine("Сума парних елементів: " + EvenSum(array));
            Console.WriteLine("Сума не парних елементів: " + OddSum(array));
            Console.WriteLine("Сума елементів які діляться на 3: " + CanDivide3Sum(array));
            Console.WriteLine("");
            Console.ReadLine();
        }

        static int EvenSum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static int OddSum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if(item % 2 != 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static int CanDivide3Sum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item % 3 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
