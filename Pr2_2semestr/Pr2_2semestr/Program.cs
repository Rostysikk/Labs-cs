using System;

class Program
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();

        Display display = new Display();
        AirConditioner ac = new AirConditioner();
        SecuritySystem security = new SecuritySystem();

        display.Subscribe(sensor);
        ac.Subscribe(sensor);
        security.Subscribe(sensor);

        sensor.SetTemperature(15);
        Console.WriteLine();

        sensor.SetTemperature(22);
        Console.WriteLine();

        sensor.SetTemperature(30);
        Console.WriteLine();

        sensor.SetTemperature(45);
        Console.WriteLine();

        sensor.SetTemperature(2);
    }
}