using System;
using System.IO;

class Program
{
    static void Main()
    {
        MessagePublisher publisher = new MessagePublisher();
        FileLogger logger = new FileLogger("logPD21.txt");

        // підписка на подію
        publisher.MessageSent += logger.HandleMessage;

        // вводимо 4 рази
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Введіть текст: ");
            string message = Console.ReadLine();

            publisher.Send(message);
        }

        Console.WriteLine("Готово!");
    }
}

// клас publisher
class MessagePublisher
{
    // event
    public event Action<string> MessageSent;

    public void Send(string message)
    {
        MessageSent?.Invoke(message);
    }
}

// клас logger
class FileLogger
{
    private string filePath;

    public FileLogger(string path)
    {
        filePath = path;
    }

    // обробник події
    public void HandleMessage(string message)
    {
        string log = $"[{DateTime.Now:HH:mm:ss}] {message}";
        File.AppendAllText(filePath, log + Environment.NewLine);
    }
}