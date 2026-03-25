using System;
using System.IO;

class Program
{
    public delegate string TextOperation(string text);

    static void Main()
    {
        string inputFile = "textPD23.txt";
        string outputFile = "resultPD23.txt";

        File.WriteAllText(outputFile, "");

        ProcessFile(inputFile, outputFile, ToUpperCase);
        ProcessFile(inputFile, outputFile, CountCharacters);
        ProcessFile(inputFile, outputFile, CountWords);

        Console.WriteLine("Виконано!");
    }

    static void ProcessFile(string inputFile, string outputFile, TextOperation operation)
    {
        string text = File.ReadAllText(inputFile);

        string result = operation(text);

        File.AppendAllText(outputFile, result + Environment.NewLine + "-----" + Environment.NewLine);
    }

    static string ToUpperCase(string text)
    {
        return text.ToUpper();
    }

    static string CountCharacters(string text)
    {
        return "Кількість символів: " + text.Length;
    }

    static string CountWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return "Кількість слів: " + words.Length;
    }
}