using System;
//Variant 19
namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10, m = 10;
            int[,] array = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("Таблиця Піфагора");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
