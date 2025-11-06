using System;
using System.Text;

namespace Task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }
            return array;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return (double)GetSum(numbers) / numbers.Length;
        }

        public static int GetMin(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min) min = num;
            }
            return min;
        }

        public static int GetMax(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = GenerateRandomArray(10, 1, 100);
            Console.WriteLine("Масив чисел: " + string.Join(", ", array));
            Console.WriteLine($"Сума: {GetSum(array)}");
            Console.WriteLine($"Середнє: {GetAverage(array):F2}");
            Console.WriteLine($"Мінімум: {GetMin(array)}");
            Console.WriteLine($"Максимум: {GetMax(array)}");
        }
    }
}