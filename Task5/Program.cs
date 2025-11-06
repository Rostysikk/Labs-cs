using System;
using System.Text;

namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            if (marks.Length == 0) return 0;
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            if (marks.Length == 0) return 0;
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min) min = mark;
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            if (marks.Length == 0) return 0;
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max) max = mark;
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Група {i + 1}: Середній = {GetAverage(groups[i]):F2}, " +
                                 $"Мінімальний = {GetMin(groups[i])}, Максимальний = {GetMax(groups[i])}");
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Example jagged array for testing
            int[][] groups = new int[][]
            {
                new int[] { 80, 90, 70, 85, 60, 95, 100 },
                new int[] { 50, 75, 80, 65, 90, 95 },
                new int[] { 90, 95, 100, 92, 98 }
            };

            PrintGroupStatistics(groups);
        }
    }
}