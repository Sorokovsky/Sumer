using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            Console.Write("Введіть символ: "); symbol = (char)Console.Read();
            Console.WriteLine("Ваш символ: " + symbol);
            if (IsNumber(symbol))
            {
                Console.WriteLine("Це цифра");
            }
            else if(IsLetter(symbol))
            {
                Console.WriteLine("Це буква");
            }
            else if(IsArethmetic(symbol))
            {
                Console.WriteLine("Це знак операції");
            }
            else
            {
                Console.WriteLine("Це інше");
            }
            Console.ReadKey();
        }
        static bool IsNumber(char symbol)
        {
            switch (symbol) 
            {
                case '0':
                    {
                        return true;
                    }
                case '1':
                    {
                        return true;
                    }
                case '2':
                    {
                        return true;
                    }
                case '3':
                    {
                        return true;
                    }
                case '4':
                    {
                        return true;
                    }
                case '5':
                    {
                        return true;
                    }
                case '6':
                    {  
                        return true;
                    }
                case '7':
                    {
                        return true;
                    }
                case '8':
                    {
                        return true;
                    }
                case '9':
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        } 

        static bool IsLetter(char symbol)
        {
            if(
                ('A' <= symbol && symbol <= 'Z') ||
                ('a' <= symbol && symbol <= 'z') ||
                ('а' <= symbol && symbol <= 'я') ||
                ('А' <= symbol && symbol <= 'Я')) {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsArethmetic(char symbol)
        {
            switch(symbol)
            {
                case '+':
                    {
                        return true;
                    }
                case '-':
                    {
                        return true;
                    }
                case '*':
                    {
                        return true;
                    }
                case '/':
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
}
