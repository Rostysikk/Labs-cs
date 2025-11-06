using System;
using System.Text;

namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            return (a + b > c) && (b + c > a) && (a + c > b);
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double s = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                return "Трикутник не існує";

            bool isRight = Math.Abs((a * a + b * b - c * c)) < 0.0001 ||
                          Math.Abs((a * a + c * c - b * b)) < 0.0001 ||
                          Math.Abs((b * b + c * c - a * a)) < 0.0001;

            if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                return "Рівносторонній";
            else if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                return "Рівнобедрений";
            else if (isRight)
                return "Прямокутний";
            else
                return "Довільний";
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть три сторони трикутника (a, b, c):");
            if (double.TryParse(Console.ReadLine(), out double a) &&
                double.TryParse(Console.ReadLine(), out double b) &&
                double.TryParse(Console.ReadLine(), out double c))
            {
                if (IsValidTriangle(a, b, c))
                {
                    Console.WriteLine($"Периметр: {GetPerimeter(a, b, c):F2}");
                    Console.WriteLine($"Площа: {GetArea(a, b, c):F2}");
                    Console.WriteLine($"Тип трикутника: {GetTriangleType(a, b, c)}");
                }
                else
                {
                    Console.WriteLine("Трикутник з такими сторонами не існує!");
                }
            }
            else
            {
                Console.WriteLine("Невірний формат сторін!");
            }
        }
    }
}