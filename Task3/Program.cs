using System;
using System.Text;

namespace Task3
{
    public class Program
    {
        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            else if (age < 12)
                return "Ви дитина";
            else if (age <= 17)
                return "Підліток";
            else if (age <= 59)
                return "Дорослий";
            else
                return "Пенсіонер";
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть вік:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine(ClassifyAge(age));
            }
            else
            {
                Console.WriteLine("Невірний формат віку!");
            }
        }
    }
}