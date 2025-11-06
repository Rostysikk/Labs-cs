using System;
using System.Text;

namespace Task1
{
    public class Program
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            return IsEven(number) ? "Двері відкриваються!" : "Двері зачинені...";
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть число:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine(GetMessage(number));
            }
            else
            {
                Console.WriteLine("Невірний формат числа!");
            }
        }
    }
}